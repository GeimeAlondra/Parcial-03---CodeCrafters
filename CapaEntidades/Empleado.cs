using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empleado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpleadoId { get; set; }


        [Required]
        [MaxLength(75)]
        public string EmpleadoNombre { get; set; }

        [Required]
        [MaxLength(75)]
        public string EmpleadoApellido { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmpleadoDireccion { get; set; }

        [Required]
        public decimal EmpleadoSalario { get; set; }

        [Required]
        public string EmpleadoFechaNacimiento { get; set; }


        [Required]
        public int TipoEmpleadoId { get; set; }
        [ForeignKey("TipoEmpleadoId")]
        public TipoEmpleado TipoEmpleado { get; set; }

        [Required]
        public int SucursalId { get; set; }
        [ForeignKey("SucursalId")]
        public Sucursal Sucursal { get; set; }

    }
}
