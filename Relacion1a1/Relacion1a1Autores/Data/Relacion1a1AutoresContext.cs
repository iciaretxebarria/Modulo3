using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Relacion1a1Autores.Models;

    public class Relacion1a1AutoresContext : DbContext
    {
        public Relacion1a1AutoresContext (DbContextOptions<Relacion1a1AutoresContext> options)
            : base(options)
        {
        }

        public DbSet<Relacion1a1Autores.Models.Autor> Autor { get; set; }
        public DbSet<Relacion1a1Autores.Models.Biografia> Biografia { get; set; }
    }
