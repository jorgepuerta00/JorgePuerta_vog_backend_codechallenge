namespace VogCodeChallenge.API.Domain.AggregatesModel.CompanyAggregate
{
    using System;
    using System.Collections.Generic;
    using vogCodeChallenge.Common.Repository;

    public class Company : BaseEntity
    {
        public string Name { get; set; }
    }
}
