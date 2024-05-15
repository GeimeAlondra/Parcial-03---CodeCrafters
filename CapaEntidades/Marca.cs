
namespace CapaEntidades
{
    public class Marca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarcaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string MarcaNombre { get; set; }

    }
}
