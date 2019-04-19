using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace belt_exam.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage="Name is required")]
        [MinLength(2,ErrorMessage="Name must be 2 characters or longer!")]
        public string Name { get; set; }
        [Required(ErrorMessage="Email is required")]
        [EmailAddress]
        [MinLength(1, ErrorMessage="Email is requied!")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage="Password is required")]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [RegularExpression("^(?=.*[a-zA-Z])(?=.*[0-9])(?=.*[!@#$%^&amp;*()_+]).{8,}$",ErrorMessage="Password must have at least 8 characters and contains at least 1 letter, 1 number, and 1 special character.")]
        public string Password { get; set; }
        // [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:MM/dd/yyyy}")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        // [DisplayFormat(ApplyFormatInEditMode=true,DataFormatString="{0:MM/dd/yyyy}")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Plan> Create { get; set; }
        public List<Resevation> Join { get; set; }

        [NotMapped]
        [Required(ErrorMessage="Confirmation of password is required")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string C_Password { get; set; }
    }
}