namespace VogCodeChallenge.API.Domain.AggregatesModel.DepartmentAggregate
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Infraestructure.Factory;
    using Infraestructure.Repository;

    public class DepartmentsRepository : IRepository<Department>
    {
        private IFactory _factory;

        public DepartmentsRepository(IFactory factory)
        {
            _factory = factory;
        }

        public async Task<IEnumerable<Department>> GetAll()
        {
            return await _factory.DaoDepartment.GetAll();
        }

        public async Task<IList<Department>> ListAll()
        {
            return await _factory.DaoDepartment.ListAll();
        }
    }
}
