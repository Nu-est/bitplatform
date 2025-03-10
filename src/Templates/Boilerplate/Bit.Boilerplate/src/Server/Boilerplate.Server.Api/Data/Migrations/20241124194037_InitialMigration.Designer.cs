﻿// <auto-generated />
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace Boilerplate.Server.Api.Data.Migrations;

[DbContext(typeof(AppDbContext))]
[Migration("20241124194037_InitialMigration")]
partial class InitialMigration
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Categories.Category", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("TEXT");

                b.Property<string>("Color")
                    .HasColumnType("TEXT");

                b.Property<byte[]>("ConcurrencyStamp")
                    .IsRequired()
                    .HasColumnType("BLOB");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Categories");

                b
                    .HasAnnotation("Cosmos:ContainerName", "Categories")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "Id" });

                b.HasData(
                    new
                    {
                        Id = new Guid("31d78bd0-0b4f-4e87-b02f-8f66d4ab2845"),
                        Color = "#FFCD56",
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        Name = "Ford"
                    },
                    new
                    {
                        Id = new Guid("582b8c19-0709-4dae-b7a6-fa0e704dad3c"),
                        Color = "#FF6384",
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        Name = "Nissan"
                    },
                    new
                    {
                        Id = new Guid("6fae78f3-b067-40fb-a2d5-9c8dd5eb2e08"),
                        Color = "#4BC0C0",
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        Name = "Benz"
                    },
                    new
                    {
                        Id = new Guid("ecf0496f-f1e3-4d92-8fe4-0d7fa2b4ffa4"),
                        Color = "#FF9124",
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        Name = "BMW"
                    },
                    new
                    {
                        Id = new Guid("747f6d66-7524-40ca-8494-f65e85b5ee5d"),
                        Color = "#2B88D8",
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        Name = "Tesla"
                    });
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Identity.Role", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("TEXT");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("TEXT")
                    .HasAnnotation("Cosmos:PropertyName", "_etag");

                b.Property<string>("Name")
                    .HasMaxLength(50)
                    .HasColumnType("TEXT");

                b.Property<string>("NormalizedName")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("NormalizedName")
                    .IsUnique()
                    .HasDatabaseName("RoleNameIndex");

                b.ToTable("Roles", (string)null);

                b
                    .HasAnnotation("Cosmos:ContainerName", "Roles")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "Id" });
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Identity.User", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("TEXT");

                b.Property<int>("AccessFailedCount")
                    .HasColumnType("INTEGER");

                b.Property<long?>("BirthDate")
                    .HasColumnType("INTEGER");

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken()
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnType("TEXT")
                    .HasAnnotation("Cosmos:PropertyName", "_etag");

                b.Property<long?>("ElevatedAccessTokenRequestedOn")
                    .HasColumnType("INTEGER");

                b.Property<string>("Email")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<bool>("EmailConfirmed")
                    .HasColumnType("INTEGER");

                b.Property<long?>("EmailTokenRequestedOn")
                    .HasColumnType("INTEGER");

                b.Property<string>("FullName")
                    .HasColumnType("TEXT");

                b.Property<int?>("Gender")
                    .HasColumnType("INTEGER");

                b.Property<bool>("LockoutEnabled")
                    .HasColumnType("INTEGER");

                b.Property<long?>("LockoutEnd")
                    .HasColumnType("INTEGER");

                b.Property<string>("NormalizedEmail")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<string>("NormalizedUserName")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.Property<long?>("OtpRequestedOn")
                    .HasColumnType("INTEGER");

                b.Property<string>("PasswordHash")
                    .HasColumnType("TEXT");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("TEXT");

                b.Property<bool>("PhoneNumberConfirmed")
                    .HasColumnType("INTEGER");

                b.Property<long?>("PhoneNumberTokenRequestedOn")
                    .HasColumnType("INTEGER");

                b.Property<string>("ProfileImageName")
                    .HasColumnType("TEXT");

                b.Property<long?>("ResetPasswordTokenRequestedOn")
                    .HasColumnType("INTEGER");

                b.Property<string>("SecurityStamp")
                    .HasColumnType("TEXT");

                b.Property<bool>("TwoFactorEnabled")
                    .HasColumnType("INTEGER");

                b.Property<long?>("TwoFactorTokenRequestedOn")
                    .HasColumnType("INTEGER");

                b.Property<string>("UserName")
                    .HasMaxLength(256)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("Email")
                    .IsUnique()
                    .HasFilter("[Email] IS NOT NULL");

                b.HasIndex("NormalizedEmail")
                    .HasDatabaseName("EmailIndex");

                b.HasIndex("NormalizedUserName")
                    .IsUnique()
                    .HasDatabaseName("UserNameIndex");

                b.HasIndex("PhoneNumber")
                    .IsUnique()
                    .HasFilter("[PhoneNumber] IS NOT NULL");

                b.ToTable("Users", (string)null);

                b
                    .HasAnnotation("Cosmos:ContainerName", "Users")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "Id" });

                b.HasData(
                    new
                    {
                        Id = new Guid("8ff71671-a1d6-4f97-abb9-d87d7b47d6e7"),
                        AccessFailedCount = 0,
                        BirthDate = 1306790461440000000L,
                        ConcurrencyStamp = "315e1a26-5b3a-4544-8e91-2760cd28e231",
                        Email = "test@bitplatform.dev",
                        EmailConfirmed = true,
                        EmailTokenRequestedOn = 1306790461440000000L,
                        FullName = "Boilerplate test account",
                        Gender = 0,
                        LockoutEnabled = true,
                        NormalizedEmail = "TEST@BITPLATFORM.DEV",
                        NormalizedUserName = "TEST",
                        PasswordHash = "AQAAAAIAAYagAAAAEP0v3wxkdWtMkHA3Pp5/JfS+42/Qto9G05p2mta6dncSK37hPxEHa3PGE4aqN30Aag==",
                        PhoneNumber = "+31684207362",
                        PhoneNumberConfirmed = true,
                        SecurityStamp = "959ff4a9-4b07-4cc1-8141-c5fc033daf83",
                        TwoFactorEnabled = false,
                        UserName = "test"
                    });
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Identity.UserSession", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("TEXT");

                b.Property<string>("Address")
                    .HasColumnType("TEXT");

                b.Property<string>("DeviceInfo")
                    .HasColumnType("TEXT");

                b.Property<string>("IP")
                    .HasColumnType("TEXT");

                b.Property<bool>("Privileged")
                    .HasColumnType("INTEGER");

                b.Property<long?>("RenewedOn")
                    .HasColumnType("INTEGER");

                b.Property<long>("StartedOn")
                    .HasColumnType("INTEGER");

                b.Property<Guid>("UserId")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("UserSessions");
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Products.Product", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("TEXT");

                b.Property<Guid>("CategoryId")
                    .HasColumnType("TEXT");

                b.Property<byte[]>("ConcurrencyStamp")
                    .IsRequired()
                    .HasColumnType("BLOB");

                b.Property<long>("CreatedOn")
                    .HasColumnType("INTEGER");

                b.Property<string>("Description")
                    .HasMaxLength(512)
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnType("TEXT");

                b.Property<decimal>("Price")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("CategoryId");

                b.ToTable("Products");

                b
                    .HasAnnotation("Cosmos:ContainerName", "Products")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "CategoryId" });

                b.HasData(
                    new
                    {
                        Id = new Guid("9a59dda2-7b12-4cc1-9658-d2586eef91d4"),
                        CategoryId = new Guid("31d78bd0-0b4f-4e87-b02f-8f66d4ab2845"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306466648064000000L,
                        Description = "The Ford Mustang is ranked #1 in Sports Cars",
                        Name = "Mustang",
                        Price = 27155m
                    },
                    new
                    {
                        Id = new Guid("a42914e2-92da-4f0b-aab0-b9572c9671b4"),
                        CategoryId = new Guid("31d78bd0-0b4f-4e87-b02f-8f66d4ab2845"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306457800704000000L,
                        Description = "The Ford GT is a mid-engine two-seater sports car manufactured and marketed by American automobile manufacturer",
                        Name = "GT",
                        Price = 500000m
                    },
                    new
                    {
                        Id = new Guid("f75325c8-a213-470b-ab93-4677ca4caeef"),
                        CategoryId = new Guid("31d78bd0-0b4f-4e87-b02f-8f66d4ab2845"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306440105984000000L,
                        Description = "Ford Ranger is a nameplate that has been used on multiple model lines of pickup trucks sold by Ford worldwide.",
                        Name = "Ranger",
                        Price = 25000m
                    },
                    new
                    {
                        Id = new Guid("43a82ec1-aab6-445f-83af-a85028417cf7"),
                        CategoryId = new Guid("31d78bd0-0b4f-4e87-b02f-8f66d4ab2845"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306431258624000000L,
                        Description = "Raptor is a SCORE off-road trophy truck living in a asphalt world",
                        Name = "Raptor",
                        Price = 53205m
                    },
                    new
                    {
                        Id = new Guid("f01b32bb-eccd-43be-aaf3-3c788a7d7558"),
                        CategoryId = new Guid("31d78bd0-0b4f-4e87-b02f-8f66d4ab2845"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306422411264000000L,
                        Description = "The Ford Maverick is a compact pickup truck produced by Ford Motor Company.",
                        Name = "Maverick",
                        Price = 22470m
                    },
                    new
                    {
                        Id = new Guid("d53bb159-f4f9-493a-b4dc-215fd765ca25"),
                        CategoryId = new Guid("582b8c19-0709-4dae-b7a6-fa0e704dad3c"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306466648064000000L,
                        Description = "A powerful convertible sports car",
                        Name = "Roadster",
                        Price = 42800m
                    },
                    new
                    {
                        Id = new Guid("74bb268f-18cf-45ec-9f2f-30b34b18fb3c"),
                        CategoryId = new Guid("582b8c19-0709-4dae-b7a6-fa0e704dad3c"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306457800704000000L,
                        Description = "A perfectly adequate family sedan with sharp looks",
                        Name = "Altima",
                        Price = 24550m
                    },
                    new
                    {
                        Id = new Guid("eb787e1a-7ba8-4708-924b-9f7964fa0f64"),
                        CategoryId = new Guid("582b8c19-0709-4dae-b7a6-fa0e704dad3c"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306440105984000000L,
                        Description = "Legendary supercar with AWD, 4 seats, a powerful V6 engine and the latest tech",
                        Name = "GT-R",
                        Price = 113540m
                    },
                    new
                    {
                        Id = new Guid("362a6638-0031-485d-825f-e8aeae63a334"),
                        CategoryId = new Guid("582b8c19-0709-4dae-b7a6-fa0e704dad3c"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306422411264000000L,
                        Description = "A new smart SUV",
                        Name = "Juke",
                        Price = 28100m
                    },
                    new
                    {
                        Id = new Guid("8629931e-e26e-4885-b561-e447197d4b69"),
                        CategoryId = new Guid("6fae78f3-b067-40fb-a2d5-9c8dd5eb2e08"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306466648064000000L,
                        Description = "",
                        Name = "H247",
                        Price = 54950m
                    },
                    new
                    {
                        Id = new Guid("a1c1987d-ee6c-41ad-9647-18de4504303a"),
                        CategoryId = new Guid("6fae78f3-b067-40fb-a2d5-9c8dd5eb2e08"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306457800704000000L,
                        Description = "",
                        Name = "V297",
                        Price = 103360m
                    },
                    new
                    {
                        Id = new Guid("59eea437-bdf2-4c11-b262-06643b253288"),
                        CategoryId = new Guid("6fae78f3-b067-40fb-a2d5-9c8dd5eb2e08"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306422411264000000L,
                        Description = "",
                        Name = "R50",
                        Price = 2000000m
                    },
                    new
                    {
                        Id = new Guid("01d223a3-182d-406a-9722-19dab083f96e"),
                        CategoryId = new Guid("ecf0496f-f1e3-4d92-8fe4-0d7fa2b4ffa4"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306466648064000000L,
                        Description = "",
                        Name = "M550i",
                        Price = 77790m
                    },
                    new
                    {
                        Id = new Guid("64a2616f-3af6-4248-86cf-4a605095a644"),
                        CategoryId = new Guid("ecf0496f-f1e3-4d92-8fe4-0d7fa2b4ffa4"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306457800704000000L,
                        Description = "",
                        Name = "540i",
                        Price = 60945m
                    },
                    new
                    {
                        Id = new Guid("ac50dc29-4b7e-4d4d-b23a-4227d91f2bb0"),
                        CategoryId = new Guid("ecf0496f-f1e3-4d92-8fe4-0d7fa2b4ffa4"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306448953344000000L,
                        Description = "",
                        Name = "530e",
                        Price = 56545m
                    },
                    new
                    {
                        Id = new Guid("fb41cc51-9abd-4b45-b0d9-ea8f565ec502"),
                        CategoryId = new Guid("ecf0496f-f1e3-4d92-8fe4-0d7fa2b4ffa4"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306440105984000000L,
                        Description = "",
                        Name = "530i",
                        Price = 55195m
                    },
                    new
                    {
                        Id = new Guid("e159b1ad-12aa-4e02-a39b-d5e4a32eaf99"),
                        CategoryId = new Guid("ecf0496f-f1e3-4d92-8fe4-0d7fa2b4ffa4"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306431258624000000L,
                        Description = "",
                        Name = "M850i",
                        Price = 100045m
                    },
                    new
                    {
                        Id = new Guid("4d9cb0f4-1f32-45d5-8c84-d7f15bc569d5"),
                        CategoryId = new Guid("ecf0496f-f1e3-4d92-8fe4-0d7fa2b4ffa4"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306422411264000000L,
                        Description = "",
                        Name = "X7",
                        Price = 77980m
                    },
                    new
                    {
                        Id = new Guid("1b22319e-0a58-471e-82b6-75cd8b9d98e1"),
                        CategoryId = new Guid("ecf0496f-f1e3-4d92-8fe4-0d7fa2b4ffa4"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306413563904000000L,
                        Description = "",
                        Name = "IX",
                        Price = 87000m
                    },
                    new
                    {
                        Id = new Guid("96c73b9c-03df-4f70-ac8d-75c32b89881a"),
                        CategoryId = new Guid("747f6d66-7524-40ca-8494-f65e85b5ee5d"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306466648064000000L,
                        Description = "rapid acceleration and dynamic handling",
                        Name = "Model 3",
                        Price = 61990m
                    },
                    new
                    {
                        Id = new Guid("840ba759-bde9-4821-b49b-c981c082bb96"),
                        CategoryId = new Guid("747f6d66-7524-40ca-8494-f65e85b5ee5d"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306457800704000000L,
                        Description = "finishes near the top of our luxury electric car rankings.",
                        Name = "Model S",
                        Price = 135000m
                    },
                    new
                    {
                        Id = new Guid("840e113b-5074-4b1c-86bd-e9affb659412"),
                        CategoryId = new Guid("747f6d66-7524-40ca-8494-f65e85b5ee5d"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306448953344000000L,
                        Description = "Heart-pumping acceleration, long drive range",
                        Name = "Model X",
                        Price = 138890m
                    },
                    new
                    {
                        Id = new Guid("b2db9074-a0a9-4054-87e2-206b7a55c793"),
                        CategoryId = new Guid("747f6d66-7524-40ca-8494-f65e85b5ee5d"),
                        ConcurrencyStamp = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 },
                        CreatedOn = 1306422411264000000L,
                        Description = "extensive driving range, lots of standard safety features",
                        Name = "Model Y",
                        Price = 67790m
                    });
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.PushNotification.PushNotificationSubscription", b =>
            {
                b.Property<string>("DeviceId")
                    .HasColumnType("TEXT");

                b.Property<string>("Auth")
                    .HasColumnType("TEXT");

                b.Property<string>("Endpoint")
                    .HasColumnType("TEXT");

                b.Property<long>("ExpirationTime")
                    .HasColumnType("INTEGER");

                b.Property<string>("P256dh")
                    .HasColumnType("TEXT");

                b.Property<string>("Platform")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("PushChannel")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<long>("RenewedOn")
                    .HasColumnType("INTEGER");

                b.PrimitiveCollection<string>("Tags")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<Guid?>("UserSessionId")
                    .HasColumnType("TEXT");

                b.HasKey("DeviceId");

                b.HasIndex("UserSessionId")
                    .IsUnique()
                    .HasFilter("[UserSessionId] IS NOT NULL");

                b.ToTable("PushNotificationSubscriptions");

                b
                    .HasAnnotation("Cosmos:ContainerName", "PushNotificationSubscriptions")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "Platform" });
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Todo.TodoItem", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("TEXT");

                b.Property<long>("Date")
                    .HasColumnType("INTEGER");

                b.Property<bool>("IsDone")
                    .HasColumnType("INTEGER");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<Guid>("UserId")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("TodoItems");

                b
                    .HasAnnotation("Cosmos:ContainerName", "TodoItems")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "Id" });
            });

        modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("FriendlyName")
                    .HasColumnType("TEXT");

                b.Property<string>("Xml")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("DataProtectionKeys");

                b
                    .HasAnnotation("Cosmos:ContainerName", "DataProtectionKeys")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "Id" });
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("ClaimType")
                    .HasColumnType("TEXT");

                b.Property<string>("ClaimValue")
                    .HasColumnType("TEXT");

                b.Property<Guid>("RoleId")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.ToTable("RoleClaims", (string)null);

                b
                    .HasAnnotation("Cosmos:ContainerName", "RoleClaims")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "RoleId" });
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("ClaimType")
                    .HasColumnType("TEXT");

                b.Property<string>("ClaimValue")
                    .HasColumnType("TEXT");

                b.Property<Guid>("UserId")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.ToTable("UserClaims", (string)null);

                b
                    .HasAnnotation("Cosmos:ContainerName", "UserClaims")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "UserId" });
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
            {
                b.Property<string>("LoginProvider")
                    .HasColumnType("TEXT");

                b.Property<string>("ProviderKey")
                    .HasColumnType("TEXT");

                b.Property<string>("ProviderDisplayName")
                    .HasColumnType("TEXT");

                b.Property<Guid>("UserId")
                    .HasColumnType("TEXT");

                b.HasKey("LoginProvider", "ProviderKey");

                b.HasIndex("UserId");

                b.ToTable("UserLogins", (string)null);

                b
                    .HasAnnotation("Cosmos:ContainerName", "UserLogins")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "UserId" });
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
            {
                b.Property<Guid>("UserId")
                    .HasColumnType("TEXT");

                b.Property<Guid>("RoleId")
                    .HasColumnType("TEXT");

                b.HasKey("UserId", "RoleId");

                b.HasIndex("RoleId");

                b.ToTable("UserRoles", (string)null);

                b
                    .HasAnnotation("Cosmos:ContainerName", "UserRoles")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "UserId" });
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
            {
                b.Property<Guid>("UserId")
                    .HasColumnType("TEXT");

                b.Property<string>("LoginProvider")
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .HasColumnType("TEXT");

                b.Property<string>("Value")
                    .HasColumnType("TEXT");

                b.HasKey("UserId", "LoginProvider", "Name");

                b.ToTable("UserTokens", (string)null);

                b
                    .HasAnnotation("Cosmos:ContainerName", "UserTokens")
                    .HasAnnotation("Cosmos:PartitionKeyNames", new List<string> { "UserId" });
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Identity.UserSession", b =>
            {
                b.HasOne("Boilerplate.Server.Api.Models.Identity.User", "User")
                    .WithMany("Sessions")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("User");
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Products.Product", b =>
            {
                b.HasOne("Boilerplate.Server.Api.Models.Categories.Category", "Category")
                    .WithMany("Products")
                    .HasForeignKey("CategoryId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Category");
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.PushNotification.PushNotificationSubscription", b =>
            {
                b.HasOne("Boilerplate.Server.Api.Models.Identity.UserSession", "UserSession")
                    .WithOne("PushNotificationSubscription")
                    .HasForeignKey("Boilerplate.Server.Api.Models.PushNotification.PushNotificationSubscription", "UserSessionId");

                b.Navigation("UserSession");
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Todo.TodoItem", b =>
            {
                b.HasOne("Boilerplate.Server.Api.Models.Identity.User", "User")
                    .WithMany("TodoItems")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("User");
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
            {
                b.HasOne("Boilerplate.Server.Api.Models.Identity.Role", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
            {
                b.HasOne("Boilerplate.Server.Api.Models.Identity.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
            {
                b.HasOne("Boilerplate.Server.Api.Models.Identity.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
            {
                b.HasOne("Boilerplate.Server.Api.Models.Identity.Role", null)
                    .WithMany()
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Boilerplate.Server.Api.Models.Identity.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
            {
                b.HasOne("Boilerplate.Server.Api.Models.Identity.User", null)
                    .WithMany()
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Categories.Category", b =>
            {
                b.Navigation("Products");
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Identity.User", b =>
            {
                b.Navigation("Sessions");

                b.Navigation("TodoItems");
            });

        modelBuilder.Entity("Boilerplate.Server.Api.Models.Identity.UserSession", b =>
            {
                b.Navigation("PushNotificationSubscription");
            });
#pragma warning restore 612, 618
    }
}
