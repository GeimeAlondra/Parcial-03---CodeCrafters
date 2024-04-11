using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Direccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DireccionId { get; set; }

        [MaxLength(75)]
        public string Calle { get; set; }

        [Required]
        [MaxLength(75)]
        public string Municipio { get; set; }

        [Required]
        [MaxLength(100)]
        public string Ciudad { get; set; }

        [MaxLength(10)]
        public int NumeroCasa { get; set; }
    }
}
