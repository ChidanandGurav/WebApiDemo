﻿using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db) // DI pattern inject dependency in constructor.
        {
            this.db = db;
        }
        public int AddStudent(Student student)
        {
            db.Students.Add(student);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int res = 0;
            var result = db.Students.Where(x => x.RollNo == id).FirstOrDefault();
            if (result != null)
            {
                db.Students.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        public Student GetStudentByRollNo(int id)
        {
            var result = db.Students.Where(x => x.RollNo == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public int UpdateStudent(Student student)
        {
            int res = 0;


            var result = db.Students.Where(x => x.RollNo == student.RollNo).FirstOrDefault();

            if (result != null)
            {
                result.Name = student.Name; // book contains new data, result contains old data
                result.City = student.City;
                result.Percentage = student.Percentage;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }
    }
}
