namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}