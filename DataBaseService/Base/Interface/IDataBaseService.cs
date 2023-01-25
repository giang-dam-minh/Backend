using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataBaseService.Base.Interface
{
    public interface IDataBaseService
    {
        public Task<T> QueryCommandTextAsync<T>(string query, Dictionary<string, object> param, Transaction transaction);
    }
}
