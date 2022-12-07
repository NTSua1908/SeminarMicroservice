using SeminarMicroservice.DTO.Information;
using SeminarMicroservice.DTO.Pagination;

namespace SeminarMicroservice.Services.Interface
{
    public interface IInformationService
    {
        PaginationModel<CitizenIdentityModel> GetCitizenIdentities(PaginationRequest req);
        CitizenIdentityModel GetCitizenIdentityByToken();
        PaginationModel<HealthInsuranceModel> GetHealthInsurances(PaginationRequest req);
        HealthInsuranceModel GetHealthInsuranceByToken();
        PaginationModel<DrivingLicenseModel> GetDrivingLicenses(PaginationRequest req);
        DrivingLicenseModel GetDrivingLicenseByToken();
    }
}
