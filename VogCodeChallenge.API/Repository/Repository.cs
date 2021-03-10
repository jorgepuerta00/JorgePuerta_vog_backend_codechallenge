using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Repository
{
    public class Repository : IRepository
    {
        public IEnumerable<Employee> GetAll()
        {
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

            return employeeInMemoryDatabase;
        }

        public IList<Employee> ListAll()
        {
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

            return employeeInMemoryDatabase;
        }
    }
}
