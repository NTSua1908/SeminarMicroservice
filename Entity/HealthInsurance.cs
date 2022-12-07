using SeminarMicroservice.Entity;
using SeminarMicroservice.Helper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarMicroservice.Entity
{
    public class HealthInsurance
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string IdCard { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public string AreaCode { get; set; }
        public string Address { get; set; }
        public string FirstInsuranceHealthCareProvider { get; set; }
        public string InsuranceHealthCareCode { get; set; }
        public DateTime ValidDate { get; set; }
        public DateTime FiveYearsDate { get; set; }
        public string IssueDate { get; set; }
        public string GrantorName { get; set; }
        public string TitleOfGrantor { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
