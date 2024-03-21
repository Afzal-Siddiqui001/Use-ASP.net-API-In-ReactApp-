using Microsoft.EntityFrameworkCore;
namespace codefirst.Model
{
    
        public class StudentDbContext : DbContext
        {
            public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
            {
            }
            public DbSet<Student> Student { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Data Source=.; Initial Catalog=Dummy; User Id=sa; password=aptech; TrustServerCertificate= True");
            }
        }
    }

