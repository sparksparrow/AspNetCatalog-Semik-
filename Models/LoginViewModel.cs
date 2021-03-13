using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(300)]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required]
        [StringLength(30)]
        [UIHint("password")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня?")]
        public bool RememberMe { get; set; }
    }
}
