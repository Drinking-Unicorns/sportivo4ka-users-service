using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportivo4ka.Users.Data.Entity
{
    public class Points : Base2
    {
        public int EventId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public float Count { get; set; }
    }
}
