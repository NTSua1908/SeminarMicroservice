using SeminarMicroservice.Entity;
using SeminarMicroservice.Helper;

namespace SeminarMicroservice.DTO.Information
{
    public class HealthInsuranceModel
    {
        public string IdCard { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Sex { get; set; }
        public string Nationality { get; set; }
        public string AreaCode { get; set; }
        public string Address { get; set; }
        public string FirstInsuranceHealthCareProvider { get; set; }
        public string InsuranceHealthCareCode { get; set; }
        public DateTime ValidDate { get; set; }
        public DateTime FiveYearsDate { get; set; }
        public DateTime IssueDate { get; set; }
        public string GrantorName { get; set; }
        public string TitleOfGrantor { get; set; }

        public HealthInsuranceModel(HealthInsurance healthInsurance)
        {
            IdCard = healthInsurance.IdCard;
            FullName = healthInsurance.FullName;
            DateOfBirth = healthInsurance.DateOfBirth;
            Sex = healthInsurance.Sex;
            Nationality = healthInsurance.Nationality;
            AreaCode = healthInsurance.AreaCode;
            Address = healthInsurance.Address;
            FirstInsuranceHealthCareProvider = healthInsurance.FirstInsuranceHealthCareProvider;
            InsuranceHealthCareCode = healthInsurance.InsuranceHealthCareCode;
            ValidDate = healthInsurance.ValidDate;
            FiveYearsDate = healthInsurance.FiveYearsDate;
            IssueDate = healthInsurance.IssueDate;
            GrantorName = healthInsurance.GrantorName;
            TitleOfGrantor = healthInsurance.GrantorName;
        }
    }
}
