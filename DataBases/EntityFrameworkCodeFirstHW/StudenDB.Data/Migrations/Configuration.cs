namespace StudenDB.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    using StudentDB.Models.Enums;
    using StudentDB.Models.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "StudentDB.Data.StudentContext";
        }

        protected override void Seed(StudentContext context)
        {
            SeedCourses(context);
            SeedStudents(context);
            AddHomeworksToSpecificStudent(context);
        }

        private static void SeedCourses(StudentContext context)
        {
            if (context.Courses.Any())
            {
                return;
            }

            context.Courses.Add(new Course()
            {
                Description = "C# OOP",
                Homeworks = new List<Homework>()
                {
                    new Homework()
                    {
                        Content = "C# OOP - Abstraction",
                        Materials = new List<Material>()
                        {
                            new Material()
                            {
                                Type = MaterialType.Presentation,
                                DownloadUrl = @"http://telerikacademy.com/"
                            },
                            new Material()
                            {
                                Type = MaterialType.SourceCode,
                                DownloadUrl = @"http://telerikacademy.com/"
                            }
                        }
                    }
                }
            });

            context.Courses.Add(new Course()
            {
                Description = "DataBases",
                Homeworks = new List<Homework>()
                {
                    new Homework()
                    {
                        Content = "Entity Framework",
                        Materials = new List<Material>()
                        {
                            new Material()
                            {
                                Type = MaterialType.Presentation,
                                DownloadUrl = @"http://telerikacademy.com/"
                            }
                        }
                    }
                }
            });

            context.Courses.Add(new Course()
            {
                Description = "Design Patterns"
            });

            context.Courses.Add(new Course()
            {
                Description = "PHP Web-Development"
            });

            context.Courses.Add(new Course()
            {
                Description = "Frond-End-Developing"
            });

            context.SaveChanges();
        }

        private static void SeedStudents(StudentContext context)
        {
            if (context.Students.Any())
            {
                return;
            }

            context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Students', RESEED, 100000)");

            context.Students.Add(new Student()
            {
                Name = "Pesho Goshov",
                Courses = context.Courses.Take(2).ToList()
            });

            context.Students.Add(new Student()
            {
                Name = "Gosho Peshov"
            });

            context.SaveChanges();
        }

        private static void AddHomeworksToSpecificStudent(StudentContext context)
        {
            var firstStudent = context.Students.First();
            var someHomework = context.Courses.First().Homeworks.First();

            firstStudent.Homeworks.Add(new Homework()
            {
                Content = someHomework.Content,
                Course = someHomework.Course,
                TimeSent = DateTime.Now
            });

            context.SaveChanges();
        }
    }
}
