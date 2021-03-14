namespace VogCodeChallenge.API.Infraestructure.Repository
{
    using System.Collections.Generic;

    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IList<T> ListAll();
    }
}
