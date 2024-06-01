using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using University.Models;

namespace University.Data
{
    //WERSJA UPOŚLEDZONA
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ActivityGroup> ActivityGroup { get; set; }
        public DbSet<FieldOfStudy> FieldOfStudy { get; set; }
        public DbSet<Grade> Grade { get; set; }
        public DbSet<Lecturer> Lecturer { get; set; }
        public DbSet<LecturerSubject> LecturerSubject { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<User> User { get; set; }


    }
}
