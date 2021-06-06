using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportivo4ka.Users.Data.Entity
{
    public class Base2 : Base
    {
        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
