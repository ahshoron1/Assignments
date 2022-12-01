using Assignment01.DbContexts;
using Assignment01.Entities;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Linq;
namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            //===============Insert Data Student Table==============//

            //using (var context = new TrainingContext())
            //{
            //    var student = new Students()
            //    {
            //        Name = "Abdur Rahman",
            //        DateOfBirth = new DateTime(2005, 3, 3),
            //        Address = "Bangladesh"
            //    };
            //    context.Students.Add(student);
            //    context.SaveChanges();
            //}

            //==============Update Data Student Table===============//

            //using (var context = new TrainingContext())
            //{
            //    var student = context.Students.Where(x => x.Id == 3).FirstOrDefault();
            //    student.Name = "Abu Tha Muhammad";
            //    student.DateOfBirth = new DateTime(1987, 3, 5);
            //    student.Address = "Madina";
            //    context.SaveChanges();

            //}

            // ==============Delete Data Student Table================== //

            //using (var context = new TrainingContext())
            //{
            //    var student = context.Students.Where(x => x.Id == 2).FirstOrDefault();
            //    context.Students.Remove(student);
            //    context.SaveChanges();
            //}

            ///===============Insert Data Courses Table================== // 

            //using (var context = new TrainingContext())
            //{
            //    var course = new Courses()
            //    {
            //        Title = "Compititive Programming",
            //        Fees = 6000,
            //        DurationInHours = 48
            //    };
            //    context.Courses.Add(course);
            //    context.SaveChanges();
            //}

            // ============== Update Data Course Table ================ //

            //using (var context = new TrainingContext())
            //{
            //    var course = context.Courses.Where(x => x.Id == 3).FirstOrDefault();
            //    course.Title = "Competitive Programming - Intermediate";
            //    course.Fees = 9000;
            //    course.DurationInHours = 50;
            //    context.SaveChanges();
            //}

            // =============== Delete Data Course Table ================ //

            //using (var context = new TrainingContext())
            //{
            //    var course = context.Courses.Where(x => x.Id == 3).FirstOrDefault();
            //    context.Courses.Remove(course);
            //    context.SaveChanges();
            //}

            // =============== Course && Student Table Relaton in Enrollments Table ============== // 

            //using (var context = new TrainingContext())
            //{
            //    var course = context.Courses.Where(x => x.Id == 1).FirstOrDefault();
            //    var student = context.Students.Where(x => x.Id == 2).FirstOrDefault();
            //    course.EnrollmentCourses = new List<Enrollments>();
            //    course.EnrollmentCourses.Add(new Enrollments { Student = student, EnrollDate = DateTime.Now });
            //    context.SaveChanges();
            //}


        }

    }

}
