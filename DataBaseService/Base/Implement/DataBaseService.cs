using DataBaseService.Base.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DataBaseService.Base.Implement
{
    public class DataBaseService : IDataBaseService
    {
        public Task<T> QueryCommandTextAsync<T>(string query, Dictionary<string, object> param, Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
