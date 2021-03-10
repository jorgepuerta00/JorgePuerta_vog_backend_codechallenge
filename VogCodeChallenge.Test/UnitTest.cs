namespace VogCodeChallenge.Test
{
    using Moq;
    using System;
    using System.Collections.Generic;
    using VogCodeChallenge.API.Models;
    using VogCodeChallenge.API.Repository;
    using Xunit;

    public class UnitTest
    {
        [Fact]
        public void TestEmployeeRepository()
        {
            // Arrange
            List<Employee> employeeInMemoryDatabase = new List<Employee>()
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

            var repository = new Mock<IRepository>();
            repository.Setup(x => x.ListAll()).Returns(() => employeeInMemoryDatabase);

            // Act
            var employeeList = repository.Object.ListAll();

            // Assert
            Assert.NotNull(employeeList);
            Assert.True(employeeList.Count > 0);
        }
    }
}
