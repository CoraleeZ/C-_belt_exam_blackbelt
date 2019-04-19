using System.ComponentModel.DataAnnotations;

namespace belt_exam.Models
{
    public class Login
    {  
        [Required(ErrorMessage="Email can not be empty")]
        [EmailAddress]
        public string logEmail { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage="Password can not be empty")]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        public string logPassword { get; set; }
    }
}