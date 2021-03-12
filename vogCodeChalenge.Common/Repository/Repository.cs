namespace vogCodeChallenge.Common.Repository
{
    using System;
    using System.Collections.Generic;

    public class Repository<T> : IRepository<T> where T : class
    {
        private string _connectionString;

        public Repository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<T> GetAll(string keyword)
        {
            throw new NotImplementedException();
        }

        public IList<T> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}
