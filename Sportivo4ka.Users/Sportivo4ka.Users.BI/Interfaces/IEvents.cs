using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sportivo4ka.Users.Data.Dto;

namespace Sportivo4ka.Users.BI.Interfaces
{
    public interface IEvents
    {
        Task IntegrationToEventService(IntegrationEventDto model);
    }
}
