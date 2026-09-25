namespace DatabaseTask.Core.Domain
{
    public class HealthCare
    {
        public Guid Id { get; set; }
        public string AbsenceReason { get; set; }
        public DateTime History { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}