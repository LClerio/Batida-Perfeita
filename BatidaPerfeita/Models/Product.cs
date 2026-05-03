
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BatidaPerfeita.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        [Display(Name = "Nome")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição curta é obrigatória.")]
        [Display(Name = "Descrição Curta")]
        [StringLength(300, MinimumLength = 20, ErrorMessage = "A {0} deve ter entre {2} e {1} caracteres.")]
        public string ShortDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "A descrição detalhada é obrigatória.")]
        [Display(Name = "Descrição Detalhada")]
        [StringLength(1000, MinimumLength = 20, ErrorMessage = "A {0} deve ter entre {2} e {1} caracteres.")]
        public string LongDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o preço do produto.")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1.00, 999.99, ErrorMessage = "O {0} deve estar entre {1} e {2}.")]
        public decimal Price { get; set; }

        [Display(Name = "URL da Imagem")]
        [StringLength(250, ErrorMessage = "O caminho da imagem não pode exceder {1} caracteres.")]
        public string ImageUrl { get; set; } = string.Empty;

        [Display(Name = "URL da Miniatura")]
        [StringLength(250, ErrorMessage = "O caminho da miniatura não pode exceder {1} caracteres.")]
        public string ImageThumbnailUrl { get; set; } = string.Empty;

        [Display(Name = "Destaque?")]
        public bool IsPreferredProduct { get; set; }

        [Display(Name = "Estoque")]
        public bool InStock { get; set; }

        // Relacionamento
        [Display(Name = "Categoria")]
        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
