using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportivo4ka.Users.BI.Interfaces
{
    public interface ISendData
    {
        Task Post(object data, string url, string token = null);

        Task<T> Post<T>(object data, string url, string token = null);

        Task<T> Get<T>(string url, string token = null);
    }
}
