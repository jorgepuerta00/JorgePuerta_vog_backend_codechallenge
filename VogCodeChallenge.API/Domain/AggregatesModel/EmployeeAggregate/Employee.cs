namespace VogCodeChallenge.API.Domain.AggregatesModel.EmployeeAggregate
{
    using System;
    using vogCodeChallenge.Common.Repository;
    using DepartmentAggregate;

    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string ResidenceAddress { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
