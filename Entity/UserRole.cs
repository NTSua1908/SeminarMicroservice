using Microsoft.AspNetCore.Identity;

namespace SeminarMicroservice.Entity
{
    public class UserRole : IdentityRole
    {
        public virtual ICollection<UserRoleMap> AccountRoleMaps { get; set; }
    }
}

