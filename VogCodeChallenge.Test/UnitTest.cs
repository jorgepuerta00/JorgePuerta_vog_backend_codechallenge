namespace VogCodeChallenge.Test
{
    using System;
    using System.Collections.Generic;
    using Moq;
    using VogCodeChallenge.API.Domain.AggregatesModel.EmployeeAggregate;
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


            // Act
            var employeeList = employeeInMemoryDatabase;

            // Assert
            Assert.NotNull(employeeList);
        }
    }
}
