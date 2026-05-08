using System.ComponentModel.DataAnnotations;

namespace BatidaPerfeita.Areas.Admin.Models.ViewModels
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "O nome da Role é obrigatório.")]
        [Display(Name = "Role")]
        public string RoleName { get; set; } = string.Empty;
    }
}
