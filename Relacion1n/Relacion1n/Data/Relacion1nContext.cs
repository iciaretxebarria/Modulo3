using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Relacion1n.Models;

    public class Relacion1nContext : DbContext
    {
        public Relacion1nContext (DbContextOptions<Relacion1nContext> options)
            : base(options)
        {
        }

        public DbSet<Relacion1n.Models.Autor> Autor { get; set; }
        public DbSet<Relacion1n.Models.Libro> Libro { get; set; }
    }
