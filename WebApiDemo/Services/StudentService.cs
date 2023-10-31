using WebApiDemo.Models;
using WebApiDemo.Repositories;

namespace WebApiDemo.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }
        public int AddStudent(Student student)
        {
            return repo.AddStudent(student);
        }

        public int DeleteStudent(int Rollno)
        {
            return repo.DeleteStudent(Rollno);
        }

        public Student GetStudentByRollNo(int RollNo)
        {
            return repo.GetStudentByRollNo(RollNo);
        }

        public IEnumerable<Student> GetStudents()
        {
            return repo.GetStudents();
        }

        public int UpdateStudent(Student student)
        {
           return repo.UpdateStudent(student);
        }
    }
}
