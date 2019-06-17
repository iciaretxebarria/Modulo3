using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioDepartamentos.Models
{
    public class Empresa
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [MaxLength(100)]
        public string Direccion { get; set; }

        [Required]
        public string Cif { get; set; }

        [Required]
        [MaxLength(20)]
        public string Pais { get; set; }

        public List<Departamento> Departamentos { get; set; }
    }
}
