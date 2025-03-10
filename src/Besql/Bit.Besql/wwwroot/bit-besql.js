var BitBesql = BitBesql || {};
BitBesql.version = window['bit-besql version'] = '9.1.0-pre-03';

async function synchronizeDbWithCache(file) {

    window.sqlitedb = window.sqlitedb || {
        init: false,
        cache: await caches.open('Bit-Besql')
    };

    const db = window.sqlitedb;
    
    const backupPath = `/${file}`;
    const cachePath = `/data/cache/${file.substring(0, file.indexOf('_bak'))}`;

    if (!db.init) {

        db.init = true;

        const resp = await db.cache.match(cachePath);

        if (resp && resp.ok) {

            const res = await resp.arrayBuffer();

            if (res) {
                console.log(`Restoring ${res.byteLength} bytes.`);
                window.Blazor.runtime.Module.FS.writeFile(backupPath, new Uint8Array(res));
                return 0;
            }
        }
        return -1;
    }

    if (window.Blazor.runtime.Module.FS.analyzePath(backupPath).exists) {

        const waitFlush = new Promise((done, _) => {
            setTimeout(done, 10);
        });

        await waitFlush;

        const data = window.Blazor.runtime.Module.FS.readFile(backupPath);

        const blob = new Blob([data], {
            type: 'application/octet-stream',
            ok: true,
            status: 200
        });

        const headers = new Headers({
            'content-length': blob.size
        });

        const response = new Response(blob, {
            headers
        });

        await db.cache.put(cachePath, response);

        window.Blazor.runtime.Module.FS.unlink(backupPath);

        return 1;
    }
    return -1;  
}
