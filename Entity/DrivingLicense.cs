using SeminarMicroservice.Helper;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SeminarMicroservice.Entity;

namespace SeminarMicroservice.Entity
{
    public class DrivingLicense
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string IdCard { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public string PlaceOfIssue { get; set; }
        public DateTime DateOfIssue { get; set; }
        public string Class { get; set; }
        public DateTime Expires { get; set; }
        public DateTime BeginningDate { get; set; }
        public string ClassificationOfMotorVehicles { get; set; }
        public string GrantorName { get; set; }
        public string TitleOfGrantor { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }

    }
}
