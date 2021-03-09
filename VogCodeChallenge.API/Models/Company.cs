namespace VogCodeChallenge.API.Models
{
    using System.Collections.Generic;
    using Repository;

    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
