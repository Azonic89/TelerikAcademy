namespace StudenDB.Data
{
    using System.Data.Entity;

    using StudentDB.Models.Models;
    using Migrations;

    public class StudentContext : DbContext
    {
        public StudentContext()
            : base("StudentDB.Models")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentContext, Configuration>());
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> Homeworks { get; set; }

        public DbSet<Material> Materials { get; set; }
    }
}