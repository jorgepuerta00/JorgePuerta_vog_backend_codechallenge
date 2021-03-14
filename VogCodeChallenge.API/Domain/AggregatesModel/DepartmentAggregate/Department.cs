namespace VogCodeChallenge.API.Domain.AggregatesModel.DepartmentAggregate
{
    using System;
    using vogCodeChallenge.Common.Repository;
    using CompanyAggregate;

    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
