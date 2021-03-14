namespace VogCodeChallenge.API.Infraestructure.Persistance
{
    using System.Collections.Generic;

    public interface IDao<T> where T : class
    {
        IEnumerable<T> GetAll();
        IList<T> ListAll();
    }
}