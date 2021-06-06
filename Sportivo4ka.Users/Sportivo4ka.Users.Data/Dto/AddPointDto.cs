using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportivo4ka.Users.Data.Dto
{
    public class AddPointDto
    {
        public int UserId { get; set; }

        public int EventId { get; set; }

        public float CountPoints { get; set; }
    }
}
