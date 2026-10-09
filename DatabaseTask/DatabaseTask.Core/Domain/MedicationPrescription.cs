using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class MedicationPrescription
    {
        [Key]
        public int Id { get; set; }

        public int VisitId { get; set; }
        [ForeignKey("VisitId")]
        public Visit Visit { get; set; }

        public int MedicationId { get; set; }
        [ForeignKey("MedicationId")]
        public Medication Medication { get; set; }

        public string Dosage { get; set; }
        public int TimesPerDay { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
