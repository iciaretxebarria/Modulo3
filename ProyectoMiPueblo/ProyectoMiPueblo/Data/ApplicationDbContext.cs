using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoMiPueblo.Models;

namespace ProyectoMiPueblo.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Anfitrion> Anfitriones { get; set; }

        public DbSet<ProyectoMiPueblo.Models.Estancia> Estancia { get; set; }
    }
}
