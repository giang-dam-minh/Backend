using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BaseModel
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? CreatedBy { get; set; }
        public DateTime? ModifiDate { get; set; }
        public DateTime? ModifiBy { get; set; }
    }
}
