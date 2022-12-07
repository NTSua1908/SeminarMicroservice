﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeminarMicroservice.Entity;

#nullable disable

namespace SeminarMicroservice.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.CitizenIdentity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CccdId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateOfExpiry")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("GrantorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PersonalIdentification")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PlaceOfOrigin")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PlaceOfResidence")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("TitleOfGrantor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("CitizenIdentities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b1c1de1-2588-44e7-87e9-3a15d11f87e2"),
                            CccdId = "037153000257",
                            DateOfBirth = new DateTime(1990, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfExpiry = new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Nguyen Van A",
                            GrantorName = "Nguyễn Cục Trưởng",
                            IssueDate = new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nationality = "Vietnam",
                            PersonalIdentification = "Sẹo đuôi mắt trái",
                            PlaceOfOrigin = "Tân Hòa Đông, Bình Trị Đông, Bình Tân, Thành phố Hồ Chí Minh",
                            PlaceOfResidence = "351/5A An Dương Vương, Phường 10, Quận 6, Thành phố Hồ Chí Minh",
                            Sex = 0,
                            TitleOfGrantor = "Cục trưởng cục cảnh sát quản lý hành chính về trật tự xã hội",
                            UserId = "70BD714F-9576-45BA-B5B7-F00649BE00DE"
                        });
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.DrivingLicense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("BeginningDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ClassificationOfMotorVehicles")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateOfIssue")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("GrantorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IdCard")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PlaceOfIssue")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TitleOfGrantor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("DrivingLicenses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ea30789f-83d5-4810-b008-33fcea5a03b8"),
                            Address = "351/5A An Dương Vương, Phường 10, Quận 6, Thành phố Hồ Chí Minh",
                            BeginningDate = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Class = "A1",
                            ClassificationOfMotorVehicles = "Xe mô tô hai bánh có dung tích xi-lanh từ 50 - dưới 175 cm3",
                            DateOfBirth = new DateTime(1990, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfIssue = new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Expires = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Nguyen Van A",
                            GrantorName = "Nguyễn Giám Đốc",
                            IdCard = "601195002226",
                            Nationality = "Vietnam",
                            PlaceOfIssue = "TP Hồ Chí Minh",
                            TitleOfGrantor = "Giám đốc công an",
                            UserId = "70BD714F-9576-45BA-B5B7-F00649BE00DE"
                        });
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.HealthInsurance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AreaCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstInsuranceHealthCareProvider")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FiveYearsDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("GrantorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IdCard")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("InsuranceHealthCareCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("IssueDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("TitleOfGrantor")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("ValidDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("HealthInsurances");

                    b.HasData(
                        new
                        {
                            Id = new Guid("431e6f5f-e608-47de-bee1-98d494baa913"),
                            Address = "351/5A An Dương Vương, Phường 10, Quận 6, Thành phố Hồ Chí Minh",
                            AreaCode = "K1",
                            DateOfBirth = new DateTime(1990, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstInsuranceHealthCareProvider = "TTYT Quận 6",
                            FiveYearsDate = new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FullName = "Nguyen Van A",
                            GrantorName = "Nguyễn Giám Đốc",
                            IdCard = "CN3010003500099",
                            InsuranceHealthCareCode = "01-123",
                            IssueDate = new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nationality = "Vietnam",
                            Sex = 0,
                            TitleOfGrantor = "Giám đốc bảo hiểm xã hội TP Hồ Chí Minh",
                            UserId = "70BD714F-9576-45BA-B5B7-F00649BE00DE",
                            ValidDate = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ba637654-70af-4542-be74-08c7b7329679",
                            DisplayName = "Admin",
                            Email = "admin@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHOL3nMDVqulfZR+HGhqo73qwuCJnniNwKVGSXyOXZfQbObdnAsmr0kdQfu3LnY+1w==",
                            PhoneNumber = "0397352016",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        },
                        new
                        {
                            Id = "70BD714F-9576-45BA-B5B7-F00649BE00DE",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ba637654-70af-4542-be74-08c7b7329679",
                            DisplayName = "Nguyen Van A",
                            Email = "citizen@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "CITIZEN@GMAIL.COM",
                            NormalizedUserName = "037153000257",
                            PasswordHash = "AQAAAAEAACcQAAAAEC8/nBiT+Sfy6yEWsKzkSk+b+GLST7tfcEa5K+7UHthxuZ++DOXGfB0zSD2I3jFfaA==",
                            PhoneNumber = "0397352016",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "037153000257"
                        });
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.UserRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                            ConcurrencyStamp = "6ce6f3f3-ac84-469e-96a7-8ee4b96c18e1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "1B3D7E19-B1A5-4CA2-A491-54593FA16531",
                            ConcurrencyStamp = "796ba66d-3d3d-4fe0-9e14-bcaa4dc2e4ee",
                            Name = "Citizen",
                            NormalizedName = "CITIZEN"
                        });
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.UserRoleMap", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("RoleId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            RoleId = "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                            UserId = "69BD714F-9576-45BA-B5B7-F00649BE00DE"
                        },
                        new
                        {
                            RoleId = "1B3D7E19-B1A5-4CA2-A491-54593FA16531",
                            UserId = "70BD714F-9576-45BA-B5B7-F00649BE00DE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("SeminarMicroservice.Entity.UserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SeminarMicroservice.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SeminarMicroservice.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SeminarMicroservice.Entity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.CitizenIdentity", b =>
                {
                    b.HasOne("SeminarMicroservice.Entity.User", "User")
                        .WithOne("CitizenIdentity")
                        .HasForeignKey("SeminarMicroservice.Entity.CitizenIdentity", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.DrivingLicense", b =>
                {
                    b.HasOne("SeminarMicroservice.Entity.User", "User")
                        .WithOne("DrivingLicense")
                        .HasForeignKey("SeminarMicroservice.Entity.DrivingLicense", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.HealthInsurance", b =>
                {
                    b.HasOne("SeminarMicroservice.Entity.User", "User")
                        .WithOne("HealthInsurance")
                        .HasForeignKey("SeminarMicroservice.Entity.HealthInsurance", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.UserRoleMap", b =>
                {
                    b.HasOne("SeminarMicroservice.Entity.UserRole", "Role")
                        .WithMany("AccountRoleMaps")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SeminarMicroservice.Entity.User", "User")
                        .WithMany("AccountRoleMaps")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.User", b =>
                {
                    b.Navigation("AccountRoleMaps");

                    b.Navigation("CitizenIdentity")
                        .IsRequired();

                    b.Navigation("DrivingLicense")
                        .IsRequired();

                    b.Navigation("HealthInsurance")
                        .IsRequired();
                });

            modelBuilder.Entity("SeminarMicroservice.Entity.UserRole", b =>
                {
                    b.Navigation("AccountRoleMaps");
                });
#pragma warning restore 612, 618
        }
    }
}
