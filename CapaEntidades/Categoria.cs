

namespace CapaEntidades
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CategoriaNombre { get; set; }
    }
}
