namespace VogCodeChallenge.API.Repository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models;

    public interface IRepository<T> where T : class
    { 
        public Task<IEnumerable<T>> GetAll();
        public Task<IList<T>> ListAll();
    }
}
