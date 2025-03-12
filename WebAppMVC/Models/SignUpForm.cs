using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class SignUpForm
    {
        [Display(Name = "First Name", Prompt = "Enter your first name")]
        [Required(ErrorMessage = "You must enter your first name.")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name", Prompt = "Enter your last name")]
        [Required(ErrorMessage = "You must enter your last name.")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Email Adress", Prompt = "Enter your email adress")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You must enter your email adress.")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "You must enter a valid email adress.")]
        public string Email { get; set; } = null!;

        [Display(Name = "Password", Prompt = "Make a password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must enter a password.")]
        [RegularExpression(@"^(?=.*[a-ö])(?=.*[A-Ö])(?=.*\d).{8,}$", ErrorMessage = "You must enter a strong password.")]
        public string Password { get; set; } = null!;

        [Display(Name = "Confirm Password", Prompt = "Confirm password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must enter your password.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = null!;

        [Display(Name = "Select a Client", Prompt = "Select a Client")]
        [Required(ErrorMessage = "You choose a client.")]
        public int ClientId { get; set; }
    }
}
