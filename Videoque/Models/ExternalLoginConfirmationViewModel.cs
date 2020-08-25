using System.ComponentModel.DataAnnotations;

namespace Videoque.Models
{
    public class ExternalLoginConfirmationViewModel
    {

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(12)]
        public string Phone { get; set; }
        [Display(Name = "Občanský Průkaz")]
        [Required]
        public string OP { get; set; }

    }
}