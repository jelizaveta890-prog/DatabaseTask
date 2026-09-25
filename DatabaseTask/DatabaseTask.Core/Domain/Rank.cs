namespace DatabaseTask.Core.Domain
{
    public class Rank
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}