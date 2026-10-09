using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(240)]
        public string Name { get; set; }

        public int Floor { get; set; }

        [MaxLength(100)]
        public string Phone { get; set; }

        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
