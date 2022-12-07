using Microsoft.AspNetCore.Identity;

namespace SeminarMicroservice.Entity
{
    public class UserRoleMap : IdentityUserRole<string>
    {
        public virtual User User { get; set; }
        public virtual UserRole Role { get; set; }
    }
}
