namespace VogCodeChallenge.Test
{
    using Moq;
    using System;
    using System.Collections.Generic;
    using VogCodeChallenge.API.Domain.AggregatesModel.EmployeeAggregate;
    using VogCodeChallenge.API.Infraestructure.Repository;
    using Xunit;
    using System.Linq;
    using System.Threading.Tasks;
    using VogCodeChallenge.API.Domain.AggregatesModel.DepartmentAggregate;

    public class UnitTest
    {
        [Fact]
        public void TestEmployeeRepository()
        {
            // Arrange
            IEnumerable<Employee> employeeInMemoryDatabase = new List<Employee>()
            {
                new Employee()
                {
                    Id = new Guid(),
                    FirstName = "George",
                    LastName = "Gates"
                },
                new Employee()
                {
                    Id = new Guid(),
                    FirstName = "Dianne",
                    LastName = "Morlotte"
                },
                new Employee()
                {
                    Id = new Guid(),
                    FirstName = "Raquel",
                    LastName = "Elsa"
                }
            };

            var repository = new Mock<IRepository<Employee>>();

            // Act
            var employeeList = repository.Setup(x => x.GetAll())
                .Returns(Task.Run(() => employeeInMemoryDatabase));

            // Assert
            Assert.NotNull(employeeList);
        }

        [Fact]
        public void TestDepartmentRepository()
        {
            // Arrange
            IEnumerable<Department> departmentInMemoryDatabase = new List<Department>()
            {
                new Department()
                {
                    Id = new Guid(),
                    Name = "Department A",
                    Address = "Ontario",
                    CompanyId = new Guid()
                },
                new Department()
                {
                    Id = new Guid(),
                    Name = "Department B",
                    Address = "New York",
                    CompanyId = new Guid()
                },
                new Department()
                {
                    Id = new Guid(),
                    Name = "Department C",
                    Address = "Medellin",
                    CompanyId = new Guid()
                }
            };

            var repository = new Mock<IRepository<Department>>();

            // Act
            var departmentList = repository.Setup(x => x.GetAll())
                .Returns(Task.Run(() => departmentInMemoryDatabase));

            // Assert
            Assert.NotNull(departmentList);
        }
    }
}
