namespace VogCodeChallenge.API.Repository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using VogCodeChallenge.API.Models;

    public interface IRepository
    { 
        public IEnumerable<Employee> GetAll();
        public IList<Employee> ListAll();
    }
}
