using SeminarMicroservice.DTO.Information;
using SeminarMicroservice.DTO.Pagination;

namespace SeminarMicroservice.Services.Interface
{
    public interface IInformationService
    {
        PaginationModel<CitizenIdentityModel> GetCitizenIdentities(PaginationRequest req);
        CitizenIdentityModel GetCitizenIdentityByToken();
    }
}
