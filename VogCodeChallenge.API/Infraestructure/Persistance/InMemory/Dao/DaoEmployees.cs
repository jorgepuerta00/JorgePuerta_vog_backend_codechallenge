namespace VogCodeChallenge.API.Infraestructure.Persistance.InMemory.Dao
{
    using System;
    using System.Collections.Generic;
    using Domain.AggregatesModel.EmployeeAggregate;

    public class DaoEmployees : IDao<Employee>
    {
        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Employee> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
