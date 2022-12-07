using SeminarMicroservice.DTO.User;
using SeminarMicroservice.DTO;
using SeminarMicroservice.Entity;
using Microsoft.AspNetCore.Identity;
using SeminarMicroservice.Services.Interface;

namespace SeminarMicroservice.Services.Implement
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly ApiDbContext _context;
        private readonly RoleManager<UserRole> _roleManager;

        public UserService(UserManager<User> userManager, ApiDbContext context, RoleManager<UserRole> roleManager)
        {
            _userManager = userManager;
            _context = context;
            _roleManager = roleManager;
        }

        public Task<ErrorModel> Login(LoginModel model)
        {
            return null;
        }

        public async Task<ErrorModel> Register(RegisterModel model)
        {
            ErrorModel error = new ErrorModel();
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                error.Add("Email already exists");
                return error;
            }

            var hasher = new PasswordHasher<User>();
            user = new User()
            {
                PasswordHash = hasher.HashPassword(null, model.Password),
                //FirstName = model.FirstName,
                //LastName = model.LastName,
                Email = model.Email,
                UserName = model.Email,
            };

            var result = await _userManager.CreateAsync(user);
            if (result.Succeeded)
            {
                var role = await _roleManager.FindByNameAsync("Citizen");
                await _userManager.AddToRoleAsync(user, role.Name);
                //var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                return error;
            }
            error.Add("Register Failed");
            return error;
        }
    }
}
