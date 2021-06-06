using Microsoft.EntityFrameworkCore;
using Sportivo4ka.Users.Data.Attributes;
using Sportivo4ka.Users.Data.Entity;
using Sportivo4ka.Users.General.Expansions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportivo4ka.Users.EF
{
    public partial class ServiceDbContext : DbContext
    {


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
