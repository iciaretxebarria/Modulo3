using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioDepartamentos.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(40)]
        public string Apellidos { get; set; }

        [Required]
        [Phone]
        public string Telefono { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
    }
}
