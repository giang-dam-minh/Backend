using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interface
{
    public interface IBaseBL
    {
        Task<T> GetByID<T>(string id);
    }
}
