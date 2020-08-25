using System.ComponentModel.DataAnnotations;

namespace Videoque.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}