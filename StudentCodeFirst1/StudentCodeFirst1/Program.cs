using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCodeFirst1
{
    class Program
    {
        static void Main(string[] args)
        { 
            using (var db = new StudentContext())
            {
                var student = new Student() { Name = " Mark Thompson" };

                var mathSubj = new Subject() { Name = "Mathematics" };
                var scienceSubj = new Subject() { Name = "DataStructures" };

                student.Subjects.Add(mathSubj);
                student.Subjects.Add(scienceSubj);

                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public virtual List<Subject> Subjects { get; set; }

        public Student()
        {
            this.Subjects = new List<Subject>();
        }
    }

    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }

        public virtual Student Students { get; set; }
    }

    class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}

