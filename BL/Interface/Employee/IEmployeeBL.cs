using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interface
{
    public interface IEmployeeBL : IBaseBL
    {
        Task<Employee> GetEmployee();
    }
}
