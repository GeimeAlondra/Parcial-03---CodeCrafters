using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoId { get; set; }

        [Required]
        [MaxLength(80)]
        public string ProductoNombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string ProductoDescripcion { get; set; }

        [Required]
        public decimal ProductoPrecio { get; set; }

        [Required]
        public int ProductoStock { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        [Required]
        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }





    }
}
