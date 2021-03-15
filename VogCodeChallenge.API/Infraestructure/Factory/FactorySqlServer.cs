namespace VogCodeChallenge.API.Infraestructure.Factory
{
    using Domain.AggregatesModel.DepartmentAggregate;
    using Domain.AggregatesModel.EmployeeAggregate;
    using Infraestructure.Persistance;
    using Infraestructure.Persistance.InMemory.Dao;

    public class FactorySqlServer : IFactory
    {
        public IDao<Employee> DaoEmployees { get; set; }
        public IDao<Department> DaoDepartment { get; set; }

        public FactorySqlServer()
        {
            DaoEmployees = new DaoEmployees();
            DaoDepartment = new DaoDepartment();
        }
    }
}
