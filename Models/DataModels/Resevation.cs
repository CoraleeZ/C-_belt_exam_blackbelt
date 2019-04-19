using System.ComponentModel.DataAnnotations;

namespace belt_exam.Models
{
    public class Resevation
    {
        [Key]
        public int ResevationId { get; set; }
        [Required]
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
        
    }
}