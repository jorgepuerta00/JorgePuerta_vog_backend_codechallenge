using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public async Task<IEnumerable<T>> GetAll()
        {
            List<Employee> employeeInMemoryDatabase = new List<Employee>()
            {
                new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "George",
                    LastName = "Gates",
                    JobTitle = "Fullstack",
                    ResidenceAddress = "Medellin"
                },
                new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Dianne",
                    LastName = "Morlotte",
                    JobTitle = "QA",
                    ResidenceAddress = "Medellin"
                },
                new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Raquel",
                    LastName = "Elsa",
                    JobTitle = "QA",
                    ResidenceAddress = "Ontario"
                }
            };

            return (IEnumerable<T>)employeeInMemoryDatabase.ToList();
        }

        public async Task<IList<T>> ListAll()
        {
            List<Employee> employeeInMemoryDatabase = new List<Employee>()
            {
                new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "George",
                    LastName = "Gates"
                },
                new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Dianne",
                    LastName = "Morlotte"
                },
                new Employee()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Raquel",
                    LastName = "Elsa"
                }
            };

            return (IList<T>)employeeInMemoryDatabase.ToList();
        }
    }
}
