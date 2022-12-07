using Microsoft.AspNetCore.Identity;
using SeminarMicroservice.Entity;

namespace SeminarMicroservice.Entity
{
    public class User : IdentityUser
    {
        public string PhoneNumber { get; set; }
        public string DisplayName { get; set; }
        public virtual ICollection<UserRoleMap> AccountRoleMaps { get; set; }
        public virtual CitizenIdentity CitizenIdentity { get; set; }
        public virtual HealthInsurance HealthInsurance { get; set; }
        public virtual DrivingLicense DrivingLicense { get; set; }
    }
}
