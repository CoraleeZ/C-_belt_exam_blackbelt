using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  belt_exam.Models
{
    public class NewPlan_wrapper
    {
        [Required]
        [MinLength(1, ErrorMessage="Title is required!")]
        public string Title { get; set; }
        [Required]
        [MinLength(1, ErrorMessage="Date is required!")]
        public String Date { get; set; }
        [Required]
        [MinLength(1, ErrorMessage="Time is required!")]
        public String Time { get; set; }
        [Required]
        [MinLength(1, ErrorMessage="Duration time is required!")]
        [RegularExpression("^[0-9]+$",ErrorMessage="Time can only be numbers")]
        public string Duration_time { get; set; }
        [Required]
        [MinLength(1, ErrorMessage="Hours? Days? or minute?")]
        public string Duration_set { get; set; }
        [Required]
        [MinLength(1, ErrorMessage="Description is required!")]
        public string Description { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}