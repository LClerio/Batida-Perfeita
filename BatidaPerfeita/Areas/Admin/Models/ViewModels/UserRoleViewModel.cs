using System.ComponentModel.DataAnnotations;

namespace BatidaPerfeita.Areas.Admin.Models.ViewModels
{
    public class UserRoleViewModel
    {
        [Required(ErrorMessage = "O nome de usuário é obrigatório.")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Role é obrigatória.")]
        public string RoleName { get; set; } = string.Empty;
    }
}
