using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeminarMicroservice.DTO.Information;
using SeminarMicroservice.DTO.Pagination;
using SeminarMicroservice.Helper;
using SeminarMicroservice.Services.Interface;

namespace SeminarMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class InfomationController : ControllerBase
    {
        private readonly IInformationService _informationService;

        public InfomationController(IInformationService informationService)
        {
            _informationService = informationService;
        } 

        [HttpGet("GetAll")]
        [Authorize(Roles = RoleConstant.Admin)]
        public PaginationModel<CitizenIdentityModel> getAll([FromQuery] PaginationRequest req)
        {
            req.Format();
            return _informationService.GetCitizenIdentities(req);
        }

        [HttpGet("GetByToken")]
        [Authorize(Roles = RoleConstant.Citizen)]
        public CitizenIdentityModel getByToken()
        {
            return _informationService.GetCitizenIdentityByToken();
        }
    }
}
