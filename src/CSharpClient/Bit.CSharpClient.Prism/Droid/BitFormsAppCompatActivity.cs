﻿#if Android

using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Bit.Droid
{
    public class BitFormsAppCompatActivity : FormsAppCompatActivity
    {
        private bool _useDefaultConfiguration = false;

        /// <summary>
        /// Configures VersionTracking | RgPluginsPopup | Fast Renderers
        /// </summary>
        protected virtual void UseDefaultConfiguration(Bundle savedInstanceState)
        {
            _useDefaultConfiguration = true;
            Forms.SetFlags("FastRenderers_Experimental");
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            VersionTracking.Track();
        }

        public override void OnBackPressed()
        {
            if (_useDefaultConfiguration == true)
            {
                Rg.Plugins.Popup.Popup.SendBackPressed(base.OnBackPressed);
            }
            else
            {
                base.OnBackPressed();
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            if (_useDefaultConfiguration == true)
            {
                Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            }

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}

#endif