using SeminarMicroservice.Entity;
using SeminarMicroservice.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SeminarMicroservice.Entity;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace SeminarMicroservice.Extentions
{
    public static class ConfigrationCustomDB
    {
        public static void ConfigrationRelationship(this ModelBuilder builder)
        {
            builder.Entity<UserRoleMap>(userRole =>
            {
                userRole.HasKey(ur => new { ur.RoleId, ur.UserId });

                userRole.HasOne(ur => ur.User)
                    .WithMany(u => u.AccountRoleMaps)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.AccountRoleMaps)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();
            });

            builder.Entity<User>(user =>
            {
                user.HasOne(u => u.CitizenIdentity)
                .WithOne(c => c.User)
                .HasForeignKey<CitizenIdentity>(c => c.UserId);

                user.HasOne(u => u.HealthInsurance)
                .WithOne(h => h.User)
                .HasForeignKey<HealthInsurance>(h => h.UserId);

                user.HasOne(u => u.DrivingLicense)
                .WithOne(d => d.User)
                .HasForeignKey<DrivingLicense>(d => d.UserId);
            });
        }

        public static void Seed(this ModelBuilder builder)
        {
            var roleIdAdmin = new string("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var roleIdCitizen = new string("1B3D7E19-B1A5-4CA2-A491-54593FA16531");
            builder.Entity<UserRole>().HasData(
                new UserRole
                {
                    Id = roleIdAdmin,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new UserRole
                {
                    Id = roleIdCitizen,
                    Name = "Citizen",
                    NormalizedName = "CITIZEN"
                }
            );

            var adminId = new string("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            var citizenId = new string("70BD714F-9576-45BA-B5B7-F00649BE00DE");
            var hasher = new PasswordHasher<User>();
            builder.Entity<User>().HasData(
                new User
                {
                    Id = adminId,
                    UserName = DefaultAdmin.UserName,
                    NormalizedUserName = DefaultAdmin.UserName.ToUpper(),
                    Email = DefaultAdmin.Email,
                    NormalizedEmail = DefaultAdmin.Email.ToUpper(),
                    EmailConfirmed = true,
                    DisplayName = DefaultAdmin.DisplayName,
                    PhoneNumber = DefaultAdmin.PhoneNumber,
                    PasswordHash = hasher.HashPassword(null, DefaultAdmin.Password),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = "ba637654-70af-4542-be74-08c7b7329679",
                },
                new User
                {
                    Id = citizenId,
                    UserName = DefaultUser.UserName,
                    NormalizedUserName = DefaultUser.UserName.ToUpper(),
                    Email = DefaultUser.Email,
                    NormalizedEmail = DefaultUser.Email.ToUpper(),
                    EmailConfirmed = true,
                    DisplayName = DefaultUser.DisplayName,
                    PhoneNumber = DefaultUser.PhoneNumber,
                    PasswordHash = hasher.HashPassword(null, DefaultUser.Password),
                    SecurityStamp = string.Empty,
                    ConcurrencyStamp = "ba637654-70af-4542-be74-08c7b7329679",
                }
            );

            builder.Entity<UserRoleMap>().HasData(
                new UserRoleMap
                {
                    RoleId = roleIdAdmin,
                    UserId = adminId
                },
                new UserRoleMap
                {
                    RoleId = roleIdCitizen,
                    UserId = citizenId
                }
            );

            builder.Entity<CitizenIdentity>().HasData(
                new CitizenIdentity()
                {
                    Id = Guid.NewGuid(),
                    UserId = citizenId,
                    CccdId = "037153000257",
                    FullName = "Nguyen Van A",
                    DateOfBirth = new DateTime(1990, 12, 3),
                    Sex = Gender.Male,
                    Nationality = "Vietnam",
                    PlaceOfOrigin = "Tân Hòa Đông, Bình Trị Đông, Bình Tân, Thành phố Hồ Chí Minh",
                    PlaceOfResidence = "351/5A An Dương Vương, Phường 10, Quận 6, Thành phố Hồ Chí Minh",
                    DateOfExpiry = new DateTime(2025, 11, 2),
                    PersonalIdentification = "Sẹo đuôi mắt trái",
                    IssueDate = new DateTime(2020, 8, 1),
                    GrantorName = "Nguyễn Cục Trưởng",
                    TitleOfGrantor = "Cục trưởng cục cảnh sát quản lý hành chính về trật tự xã hội"
                }
            );

            builder.Entity<HealthInsurance>().HasData(
                new HealthInsurance()
                {
                    Id = Guid.NewGuid(),
                    UserId = citizenId,
                    IdCard = "CN3010003500099",
                    FullName = "Nguyen Van A",
                    DateOfBirth = new DateTime(1990, 12, 3),
                    Sex = Gender.Male,
                    Nationality = "Vietnam",
                    AreaCode = "K1",
                    Address = "351/5A An Dương Vương, Phường 10, Quận 6, Thành phố Hồ Chí Minh",
                    FirstInsuranceHealthCareProvider = "TTYT Quận 6",
                    InsuranceHealthCareCode = "01-123",
                    IssueDate = new DateTime(2020, 7, 14),
                    ValidDate = new DateTime(2020, 6, 25),
                    FiveYearsDate = new DateTime(2025, 7, 14),
                    GrantorName = "Nguyễn Giám Đốc",
                    TitleOfGrantor = "Giám đốc bảo hiểm xã hội TP Hồ Chí Minh"
                }
            );

            builder.Entity<DrivingLicense>().HasData(
                new DrivingLicense()
                {
                    Id = Guid.NewGuid(),
                    UserId = citizenId,
                    IdCard = "601195002226",
                    FullName = "Nguyen Van A",
                    DateOfBirth = new DateTime(1990, 12, 3),
                    Nationality = "Vietnam",
                    Address = "351/5A An Dương Vương, Phường 10, Quận 6, Thành phố Hồ Chí Minh",
                    Class = "A1",
                    PlaceOfIssue = "TP Hồ Chí Minh",
                    ClassificationOfMotorVehicles = "Xe mô tô hai bánh có dung tích xi-lanh từ 50 - dưới 175 cm3",
                    DateOfIssue = new DateTime(2020, 7, 14),
                    Expires = new DateTime(2020, 6, 25),
                    BeginningDate = new DateTime(2020, 6, 25),
                    GrantorName = "Nguyễn Giám Đốc",
                    TitleOfGrantor = "Giám đốc công an"
                }
            ); ;
        }
    }
}
