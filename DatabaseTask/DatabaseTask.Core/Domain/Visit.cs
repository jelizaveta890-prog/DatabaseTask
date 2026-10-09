using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }

        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }

        public DateTime VisitDate { get; set; }

        public TimeSpan VisitTime { get; set; }

        [MaxLength(240)]
        public string Reason { get; set; }

        [MaxLength(1000)]
        public string Summary { get; set; } 

        public ICollection<PatientExamination> PatientExaminations { get; set; } = new List<PatientExamination>();
        public ICollection<MedicationPrescription> MedicationPrescriptions { get; set; } = new List<MedicationPrescription>();
    }
}
