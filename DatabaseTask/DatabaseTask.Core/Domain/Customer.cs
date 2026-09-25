namespace DatabaseTask.Core.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}