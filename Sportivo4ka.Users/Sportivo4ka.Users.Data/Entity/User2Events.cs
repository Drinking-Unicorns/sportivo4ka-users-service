using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportivo4ka.Users.Data.Entity
{
    public class User2Events : Base2
    {
        public int UserId { get; set; }

        public User User { get; set; }

        public int EventId { get; set; }
    }
}
