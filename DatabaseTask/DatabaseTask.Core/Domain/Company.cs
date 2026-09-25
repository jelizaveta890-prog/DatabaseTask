using DatabaseTask.Core.Domain;

public class Company
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }

    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    public ICollection<Intranet> Intranets { get; set; } = new List<Intranet>();
    public ICollection<ItemOwnedByCompany> ItemsOwnedByCompany { get; set; } = new List<ItemOwnedByCompany>();
}
