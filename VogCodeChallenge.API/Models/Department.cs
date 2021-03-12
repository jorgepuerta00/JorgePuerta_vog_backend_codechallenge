namespace VogCodeChallenge.API.Models
{
    using System;
    using System.Collections.Generic;
    using vogCodeChallenge.Common.Repository;

    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
