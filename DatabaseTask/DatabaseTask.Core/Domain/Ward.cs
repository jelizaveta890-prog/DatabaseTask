using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Ward
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string WardNr { get; set; }

        public int Floor { get; set; }
        public int BedCount { get; set; }

        // Seos: Ühes palatis viibivad paljud haiglaravid
        public ICollection<Hospitalization> Hospitalizations { get; set; } = new List<Hospitalization>();
    }
}
