using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scaffolding.Models;

namespace Scaffolding.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<Scaffolding.Models.Cocktail> Cocktail { get; set; }

        public DbSet<Scaffolding.Models.Coche> Coche { get; set; }
    }
}
