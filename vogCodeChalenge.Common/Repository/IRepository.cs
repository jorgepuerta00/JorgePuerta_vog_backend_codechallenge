namespace vogCodeChallenge.Common.Repository
{
    using System.Collections.Generic;

    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> GetAll(string keyword);
        public IList<T> ListAll();
    }
}