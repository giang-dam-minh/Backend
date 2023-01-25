using BL.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Dapper;
using Model;

namespace BL.Implemented
{
    public class BaseBL : IBaseBL
    {
        public IDbConnection _dbConnection;
        public IConfiguration _configuration;
        public BaseBL(IConfiguration configuration)
        {
            _configuration = configuration;
            _dbConnection = new MySqlConnection(_configuration.GetConnectionString("ConnectionString"));
        }

        #region Implement methods
        public async Task<T> GetByID<T>(string id)
        {
            var res = await _dbConnection.QueryAsync<T>("");
            return (T) res;
        }
        #endregion
    }
}
