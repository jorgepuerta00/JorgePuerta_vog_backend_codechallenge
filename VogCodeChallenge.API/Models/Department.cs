namespace VogCodeChallenge.API.Models
{
    using System.Collections.Generic;
    using Repository;

    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
