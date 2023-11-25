using Microsoft.EntityFrameworkCore;
using SchoolManager.Models;

namespace SchoolData
{
    public  class SchoolDbContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public SchoolDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\source\repos\SchoolManagerApp\SchoolDatabase\SchoolData.mdf;Integrated Security=True");
        }
    }
}
