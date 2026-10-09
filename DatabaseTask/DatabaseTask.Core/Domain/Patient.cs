using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string PersonalCode { get; set; }

        [Required]
        [MaxLength(290)]
        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        [MaxLength(100)]
        public string Phone { get; set; }

        [MaxLength(210)]
        public string Email { get; set; }

        
        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
        public ICollection<Hospitalization> Hospitalizations { get; set; } = new List<Hospitalization>();
    }
}
