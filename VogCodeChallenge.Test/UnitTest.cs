namespace VogCodeChallenge.Test
{
    using System;
    using System.Collections.Generic;
    using Moq;
    using vogCodeChallenge.Common.Repository;
    using VogCodeChallenge.API.Models;
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

            var repository = new Mock<IRepository<Employee>>();
            repository.Setup(x => x.ListAll());

            // Act
            var employeeList = repository.Object.ListAll();

            // Assert
            Assert.NotNull(employeeList);
        }
    }
}
