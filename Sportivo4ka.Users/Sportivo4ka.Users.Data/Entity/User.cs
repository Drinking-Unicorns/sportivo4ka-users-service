using System;
using System.Collections.Generic;
using System.Text;

namespace Sportivo4ka.Users.Data.Entity
{
    public class User : Base
    {
        public string Name { get; set; }

        public float Points { get; set; }
    }
}
