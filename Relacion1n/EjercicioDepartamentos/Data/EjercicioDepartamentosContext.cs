using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EjercicioDepartamentos.Models;

    public class EjercicioDepartamentosContext : DbContext
    {
        public EjercicioDepartamentosContext (DbContextOptions<EjercicioDepartamentosContext> options)
            : base(options)
        {
        }

        public DbSet<EjercicioDepartamentos.Models.Departamento> Departamento { get; set; }
        public DbSet<EjercicioDepartamentos.Models.Empleado> Empleado { get; set; }
    }
