namespace VogCodeChallenge.API.Infraestructure.Persistance.InMemory.Dao
{
    using System;
    using System.Collections.Generic;
    using Domain.AggregatesModel.DepartmentAggregate;

    public class DaoDepartment : IDao<Department>
    {
        public IEnumerable<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Department> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
