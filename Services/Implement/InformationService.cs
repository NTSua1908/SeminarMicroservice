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

        public DrivingLicenseModel GetDrivingLicenseByToken()
        {
            DrivingLicense drivingLicense = _dbContext.DrivingLicenses.Where(x => x.UserId == _user.GetUser()).FirstOrDefault()!;

            return new DrivingLicenseModel(drivingLicense);
        }

        public PaginationModel<DrivingLicenseModel> GetDrivingLicenses(PaginationRequest req)
        {
            List<DrivingLicense> drivingLicenses = _dbContext.DrivingLicenses.AsNoTracking().ToList();
            var drivingLicenseModels = drivingLicenses.Select(x => new DrivingLicenseModel(x)).ToList();
            return new PaginationModel<DrivingLicenseModel>(req, drivingLicenseModels);
        }

        public HealthInsuranceModel GetHealthInsuranceByToken()
        {
            HealthInsurance healthInsurance = _dbContext.HealthInsurances.Where(x => x.UserId == _user.GetUser()).FirstOrDefault()!;

            return new HealthInsuranceModel(healthInsurance);
        }

        public PaginationModel<HealthInsuranceModel> GetHealthInsurances(PaginationRequest req)
        {
            List<HealthInsurance> healthInsurances = _dbContext.HealthInsurances.AsNoTracking().ToList();
            var healthInsuranceModels = healthInsurances.Select(x => new HealthInsuranceModel(x)).ToList();
            return new PaginationModel<HealthInsuranceModel>(req, healthInsuranceModels);
        }
    }
}
