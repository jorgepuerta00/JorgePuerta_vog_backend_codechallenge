namespace VogCodeChallenge.API.Infraestructure.Factory
{
    using Domain.AggregatesModel.DepartmentAggregate;
    using Domain.AggregatesModel.EmployeeAggregate;
    using Infraestructure.Persistance;

    public interface IFactory
    {
        IDao<Employee> DaoEmployees { get; set; }
        IDao<Department> DaoDepartment { get; set; }
    }
}
