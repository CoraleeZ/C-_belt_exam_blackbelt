using Microsoft.EntityFrameworkCore;

namespace belt_exam.Models
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Useres { get; set; }
        public DbSet<Resevation> Resevationes { get; set; }
        public DbSet<Plan> Planes { get; set; }

    }
}