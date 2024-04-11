using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Sucursal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SucursalId { get; set; }

        [Required]
        [MaxLength(75)]
        public string SucursalNombre { get; set;}

        [Required]
        [MaxLength(100)]
        public string SucursalDireccion { get; set; }




    }
}
