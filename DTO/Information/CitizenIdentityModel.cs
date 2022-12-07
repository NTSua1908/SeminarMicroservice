using SeminarMicroservice.Entity;
using SeminarMicroservice.Helper;

namespace SeminarMicroservice.DTO.Information
{
    public class CitizenIdentityModel
    {
        public string No { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Sex { get; set; }
        public string Nationality { get; set; }
        public string PlaceOfOrigin { get; set; }
        public string PlaceOfResidence { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public string PersonalIdentification { get; set; }
        public DateTime IssueDate { get; set; }
        public string GrantorName { get; set; }
        public string TitleOfGrantor { get; set; }

        public CitizenIdentityModel() { }

        public CitizenIdentityModel(CitizenIdentity citizenIdentity)
        {
            No = citizenIdentity.No;
            FullName = citizenIdentity.FullName;
            DateOfBirth = citizenIdentity.DateOfBirth;
            Sex = citizenIdentity.Sex;
            Nationality = citizenIdentity.Nationality;
            PlaceOfOrigin = citizenIdentity.PlaceOfOrigin;
            PlaceOfResidence = citizenIdentity.PlaceOfResidence;
            DateOfExpiry = citizenIdentity.DateOfExpiry;
            PersonalIdentification = citizenIdentity.PersonalIdentification;
            IssueDate = citizenIdentity.IssueDate;
            GrantorName = citizenIdentity.GrantorName;
            TitleOfGrantor = citizenIdentity.TitleOfGrantor;
        }
    }
}
