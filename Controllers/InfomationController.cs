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

        [HttpGet("GetAllCitizenIdentity")]
        [Authorize(Roles = RoleConstant.Admin)]
        public PaginationModel<CitizenIdentityModel> getAllCitizenIdentity([FromQuery] PaginationRequest req)
        {
            req.Format();
            return _informationService.GetCitizenIdentities(req);
        }

        [HttpGet("GetCitizenIdentityByToken")]
        [Authorize(Roles = RoleConstant.Citizen)]
        public CitizenIdentityModel getCitizenIdentityByToken()
        {
            return _informationService.GetCitizenIdentityByToken();
        }

        [HttpGet("GetAllHealthInsurance")]
        [Authorize(Roles = RoleConstant.Admin)]
        public PaginationModel<HealthInsuranceModel> getAll([FromQuery] PaginationRequest req)
        {
            req.Format();
            return _informationService.GetHealthInsurances(req);
        }

        [HttpGet("GetHealthInsuranceByToken")]
        [Authorize(Roles = RoleConstant.Citizen)]
        public HealthInsuranceModel getHealthInsuranceByToken()
        {
            return _informationService.GetHealthInsuranceByToken();
        }

        [HttpGet("GetAllDrivingLicense")]
        [Authorize(Roles = RoleConstant.Admin)]
        public PaginationModel<DrivingLicenseModel> getAllDrivingLicense([FromQuery] PaginationRequest req)
        {
            req.Format();
            return _informationService.GetDrivingLicenses(req);
        }

        [HttpGet("GetDrivingLicenseByToken")]
        [Authorize(Roles = RoleConstant.Citizen)]
        public DrivingLicenseModel getDrivingLicenseByToken()
        {
            return _informationService.GetDrivingLicenseByToken();
        }
    }
}
