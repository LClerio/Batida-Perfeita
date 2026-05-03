using System.ComponentModel.DataAnnotations;

namespace BatidaPerfeita.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required(ErrorMessage = "O nome da categoria deve ser informado.")]
    [Display(Name = "Nome da Categoria")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
    public string Name { get; set; } = string.Empty;

    public virtual ICollection<Product>? Products { get; set; }
}
