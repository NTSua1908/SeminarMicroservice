using SeminarMicroservice.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using SeminarMicroservice.DTO;
using SeminarMicroservice.DTO.User;
using Microsoft.AspNetCore.Identity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using SeminarMicroservice.Entity;
using SeminarMicroservice.Services.Implement;
using SeminarMicroservice.Helper;

namespace SeminarMicroservice.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<UserRole> _roleManager;
        private readonly IUserService _userService;
        public UserController(SignInManager<User> signInManager, UserManager<User> userManager,
            RoleManager<UserRole> roleManager, IUserService userService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            ErrorModel error = await _userService.Register(model);
            if (!error.IsEmpty)
                return BadRequest(error);
            return Ok();
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            ErrorModel errors = new ErrorModel();

            try
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, false, false);
                var account = await _userManager.FindByNameAsync(model.UserName);
                if (result.Succeeded)
                {
                    var roleAccount = await _userManager.GetRolesAsync(account);
                    string roleName = roleAccount.Count() == 0 ? "Client" : roleAccount.First();
                    int value = (int)Enum.Parse(typeof(Role), roleName);
                    return Ok(new
                    {
                        token = JWTHelper.GenerateJwtToken(account.UserName, account.Id, value),
                    });
                }
                else
                {
                    errors.Add(ErrorResource.LoginFail);
                    return BadRequest(errors);
                }
            }
            catch (Exception e)
            {
                errors.Add(e.Message.ToString());
                return BadRequest(errors);
            }
        }
    }
}
