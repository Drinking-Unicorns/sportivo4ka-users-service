using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sportivo4ka.Users.BI.Interfaces;
using Sportivo4ka.Users.Data.Dto;
using Sportivo4ka.Users.BI.Options;

namespace Sportivo4ka.Users.BI.Services
{
    public class Events : IEvents
    {
        private readonly ISendData _sender;
        private readonly EventServiceConfig _config;

        public Events(ISendData sender, EventServiceConfig config)
        {
            _config = config;
            _sender = sender;
        }

        public async Task IntegrationToEventService(IntegrationEventDto model)
        {
            await _sender.Post(model, _config.UserGoToEvent.Url);
        }
    }
}
