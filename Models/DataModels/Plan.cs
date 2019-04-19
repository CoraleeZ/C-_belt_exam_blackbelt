using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace belt_exam.Models
{
    public class Plan
    {
        [Key]
        public int PlanId { get; set; }
        [Required]
        [MinLength(1, ErrorMessage="Title is required!")]
        public string Title { get; set; }
        [Required]
        public String Date { get; set; }
        [Required]
        public String Time { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        [MinLength(1, ErrorMessage="Description is required!")]
        public string Description { get; set; }
        [Required]
        public int UserId { get; set; }
        public List<Resevation> Guests { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public User Creator { get; set; }
    }
}