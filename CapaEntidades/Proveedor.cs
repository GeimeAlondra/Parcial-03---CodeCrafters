using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Proveedor
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProveedorId { get; set; }

        [Required]
        [MaxLength(80)]
        public string ProveedorNombre { get; set; }

        [Required]
        [MaxLength(80)]
        public string ProveedorCorreo { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProveedorDireccion { get; set; }

        [Required]
        
        public int ProveedorTelefono { get; set; }


        public List<DetallePedido> DetallePedido { get; set; }
    }
}
