using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Employee : BaseModel
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int? Age { get; set; }
    }
}
