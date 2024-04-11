using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(80)]
        public string ClienteNombre { get; set; }

        [Required]
        [MaxLength(80)]
        public string ClienteApellido { get; set; }


        [Required]
        [MaxLength(100)]
        public string ClienteDireccion { get; set; }

        [Required]
        [MaxLength(150)]
        public string ClienteCorreo { get; set; }

        
        [MaxLength(8)]
        public int ClienteTelefono{ get; set; }


        



    }
}
