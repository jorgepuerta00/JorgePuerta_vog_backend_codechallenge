namespace VogCodeChallenge.API.Infraestructure.Repository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<IList<T>> ListAll();
    }
}
