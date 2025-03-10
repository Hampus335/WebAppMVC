using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class SignUpForm
    {
        [Required(ErrorMessage = "You must enter your first name.")]
        public string FirstName { get; set; } = null!;
        [Required(ErrorMessage = "You must enter your last name.")]

        public string LastName { get; set; } = null!;
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You must enter your email adress.")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "You must enter a valid email adress.")]
        public string Email { get; set; } = null!;


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must enter a password.")]
        [RegularExpression(@"^(?=.*[a-ö])(?=.*[A-Ö])(?=.*\d)(?=.*[\W_]).{8,}$", ErrorMessage = "You must enter a strong password.")]
        public string Password { get; set; } = null!;


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "You must enter your password.")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = null!;    
    }
}
