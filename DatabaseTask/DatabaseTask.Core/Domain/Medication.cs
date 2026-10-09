using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Medication
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string ActiveIngredient { get; set; }

        [MaxLength(150)]
        public string Manufacturer { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        // Seos vahetabeliga
        public ICollection<MedicationPrescription> MedicationPrescriptions { get; set; } = new List<MedicationPrescription>();
    }
}
