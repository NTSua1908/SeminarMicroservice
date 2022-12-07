using Microsoft.EntityFrameworkCore;
using SeminarMicroservice.DTO;
using SeminarMicroservice.DTO.Information;
using SeminarMicroservice.DTO.Pagination;
using SeminarMicroservice.Entity;
using SeminarMicroservice.Helper;
using SeminarMicroservice.Services.Interface;

namespace SeminarMicroservice.Services.Implement
{
    public class InformationService : IInformationService
    {
        private readonly ApiDbContext _dbContext;
        private readonly UserResolverService _user;
        
        public InformationService(ApiDbContext dbContext, UserResolverService user)
        {
            _dbContext = dbContext;
            _user = user;
        }

        public PaginationModel<CitizenIdentityModel> GetCitizenIdentities(PaginationRequest req)
        {
            List<CitizenIdentity> citizenIdentities = _dbContext.CitizenIdentities.AsNoTracking().ToList();
            var citizenIdentityModels = citizenIdentities.Select(x => new CitizenIdentityModel(x)).ToList();
            return new PaginationModel<CitizenIdentityModel>(req, citizenIdentityModels);
        }

        public CitizenIdentityModel GetCitizenIdentityByToken()
        {
            CitizenIdentity identity = _dbContext.CitizenIdentities.Where(x => x.UserId == _user.GetUser()).FirstOrDefault()!;

            return new CitizenIdentityModel(identity);
        }
    }
}
