using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Hospitalization
    {
        [Key]
        public int Id { get; set; }

        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public int WardId { get; set; }
        [ForeignKey("WardId")]
        public Ward Ward { get; set; }

        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }

        [MaxLength(150)]
        public string Reason { get; set; }
    }
}
