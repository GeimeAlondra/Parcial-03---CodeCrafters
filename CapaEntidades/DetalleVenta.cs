

namespace CapaEntidades
{
    public class DetalleVenta
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetalleVentaId { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal Precio { get; set; }

        [Required]
        public int VentaId { get; set; }
        [ForeignKey("VentaId")]
        public Venta Venta { get; set; }



        [Required]
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public Producto Producto { get; set; }

    }
}
