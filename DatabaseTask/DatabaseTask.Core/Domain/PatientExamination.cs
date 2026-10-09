using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class PatientExamination
    {
        [Key]
        public int Id { get; set; }

        public int VisitId { get; set; }
        [ForeignKey("VisitId")]
        public Visit Visit { get; set; }

        public int ExaminationId { get; set; }
        [ForeignKey("ExaminationId")]
        public Examination Examination { get; set; }

        public DateTime ExaminationDate { get; set; }

        [MaxLength(1000)]
        public string Result { get; set; }
    }
}
