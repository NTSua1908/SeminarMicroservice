using SeminarMicroservice.Entity;
using SeminarMicroservice.Helper;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeminarMicroservice.Entity
{
    public class CitizenIdentity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
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
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
