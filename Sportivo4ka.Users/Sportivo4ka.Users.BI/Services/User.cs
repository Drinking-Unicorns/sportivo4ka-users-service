using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sportivo4ka.Users.BI.Interfaces;
using Sportivo4ka.Users.EF;
using Microsoft.EntityFrameworkCore;
using Sportivo4ka.Users.Data.Dto;
using Sportivo4ka.Users.Data.Entity;
using AutoMapper;

namespace Sportivo4ka.Users.BI.Services
{
    public class User
    {
        private readonly IEvents _events;
        private readonly ServiceDbContext _context;
        private readonly IMapper _mapper;

        public User(IMapper mapper, IEvents events, ServiceDbContext context)
        {
            _events = events;
            _context = context;
        }

        public async Task AddUserToEvent(UserToEventDto user)
        {
            var q = _context.User2Events.SingleOrDefaultAsync(x => x.UserId == user.UserId && x.EventId == user.EventId);

            if (q is not null)
                _context.Remove(q);
            else
            {
                var e = new User2Events()
                {
                    EventId = user.EventId,
                    UserId = user.UserId
                };
                _context.Add(e);
            }

            await _context.SaveChangesAsync();

            await _events.IntegrationToEventService(_mapper.Map<IntegrationEventDto>(user));
        }

        public async Task AddPoints(AddPointDto newPoints)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == newPoints.UserId);

            if(user is null)
            {

            }
            else
            {
                user.Points += newPoints.CountPoints;
                _context.Update(user);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DelPoints()
        {

        }
    }
}
