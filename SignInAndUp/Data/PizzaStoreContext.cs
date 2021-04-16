using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignInAndUp.Data
{
    public class PizzaStoreContext : DbContext
    {
        public PizzaStoreContext(DbContextOptions<PizzaStoreContext> options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set;}
    }
}
