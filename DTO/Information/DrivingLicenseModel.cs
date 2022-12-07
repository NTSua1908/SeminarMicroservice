using SeminarMicroservice.Entity;

namespace SeminarMicroservice.DTO.Information
{
    public class DrivingLicenseModel
    {
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

        public DrivingLicenseModel(DrivingLicense drivingLicense)
        {
            IdCard = drivingLicense.IdCard;
            FullName = drivingLicense.FullName;
            DateOfBirth = drivingLicense.DateOfBirth;
            Nationality = drivingLicense.Nationality;
            Address = drivingLicense.Address;
            PlaceOfIssue = drivingLicense.PlaceOfIssue;
            DateOfIssue = drivingLicense.DateOfIssue;
            Class = drivingLicense.Class;
            Expires = drivingLicense.Expires;
            BeginningDate = drivingLicense.BeginningDate;
            ClassificationOfMotorVehicles = drivingLicense.ClassificationOfMotorVehicles;
            GrantorName = drivingLicense.GrantorName;
            TitleOfGrantor = drivingLicense.TitleOfGrantor;
        }
    }
}
