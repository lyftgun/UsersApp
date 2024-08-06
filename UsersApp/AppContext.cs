using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UsersApp
{
    internal class AppContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Bank> Banks { get; set; }

        public DbSet<Basket> Baskets { get; set; }

        public AppContext(): base("DefaultConnection") { }
    }
}
