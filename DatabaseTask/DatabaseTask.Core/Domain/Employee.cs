using System;
using System.Collections;
using System.Collections.Generic;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }

        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<Child> Children { get; set; } = new List<Child>();
        public ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
        public ICollection<Rank> Ranks { get; set; } = new List<Rank>();
        public ICollection<HealthCare> HealthCares { get; set; } = new List<HealthCare>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}