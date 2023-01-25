using BL.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers.Employee
{
    public class EmployeeController : BaseController
    {

        public EmployeeController(IEmployeeBL employeeBL)
        {
            BL = employeeBL;
        }

        [HttpGet]
        [Route("/get-employee-demo")]
        public async Task<object> GetEmployee()
        {
            var res = await (BL as IEmployeeBL).GetEmployee();
            return res;
        }
    }
}
