namespace VogCodeChallenge.API.Infraestructure.Persistance
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDao<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<IList<T>> ListAll();
    }
}