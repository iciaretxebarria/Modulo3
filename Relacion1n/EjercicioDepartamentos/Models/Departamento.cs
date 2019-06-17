using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EjercicioDepartamentos.Models
{
    public class Departamento
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Nombre { get; set; }

        
        [MinLength(3)]
        [MaxLength(3)]
        public string Codigo { get; set; }

        public List<Empleado> Empleados { get; set; }

        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
