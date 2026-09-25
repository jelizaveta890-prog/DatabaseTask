using System;
using System.Collections;
using System.Collections.Generic;

namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public ICollection Employees { get; set; }
        public ICollection Intranets { get; set; }
        public ICollection ItemsOwnedByCompany { get; set; }
    }
}