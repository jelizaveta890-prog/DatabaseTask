using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string EmployeeNr { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string Specialty { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }
}
