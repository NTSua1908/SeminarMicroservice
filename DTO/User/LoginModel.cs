using System.ComponentModel.DataAnnotations;
using SeminarMicroservice.Helper;

namespace SeminarMicroservice.DTO.User
{
    public class LoginModel
    {
        [Required(ErrorMessageResourceName = "UsernameRequired", ErrorMessageResourceType = typeof(ErrorResource))]
        public string UserName { get; set; }
        [Required(ErrorMessageResourceName = "PasswordRequired", ErrorMessageResourceType = typeof(ErrorResource))]
        public string Password { get; set; }
    }
}
