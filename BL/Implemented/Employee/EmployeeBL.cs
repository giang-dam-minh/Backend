using BL.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace BL.Implemented
{
    public class EmployeeBL : BaseBL, IEmployeeBL
    {
        public EmployeeBL(IConfiguration configuration) : base(configuration)
        {

        }
        #region Implement methods
        public Task<Employee> GetEmployee()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
