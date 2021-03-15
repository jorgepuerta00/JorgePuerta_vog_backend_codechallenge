namespace VogCodeChallenge.API.Domain.AggregatesModel.EmployeeAggregate
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Infraestructure.Factory;
    using Infraestructure.Repository;

    public class EmployeesRepository : IRepository<Employee>
    {
        private IFactory _factory;

        public EmployeesRepository(IFactory factory)
        { 
            _factory = factory;
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _factory.DaoEmployees.GetAll();
        }

        public async Task<IList<Employee>> ListAll()
        {
            return await _factory.DaoEmployees.ListAll();
        }
    }
}
