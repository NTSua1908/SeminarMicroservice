using SeminarMicroservice.DTO.User;
using SeminarMicroservice.DTO;

namespace SeminarMicroservice.Services.Interface
{
    public interface IUserService
    {
        Task<ErrorModel> Register(RegisterModel model);
        Task<ErrorModel> Login(LoginModel model);
    }
}
