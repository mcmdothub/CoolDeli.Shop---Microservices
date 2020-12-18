using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
