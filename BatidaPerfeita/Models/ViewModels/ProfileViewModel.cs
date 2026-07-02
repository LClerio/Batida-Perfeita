using System.ComponentModel.DataAnnotations;

namespace BatidaPerfeita.Models.ViewModels
{
    public class ProfileViewModel
    {
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }
}
