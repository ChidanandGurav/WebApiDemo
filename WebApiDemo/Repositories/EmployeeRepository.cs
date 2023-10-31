using WebApiDemo.Data;
using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {

        ApplicationDbContext db;
        public EmployeeRepository(ApplicationDbContext db) // DI pattern inject dependency in constructor.
        {
            this.db = db;
        }

        public int AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var result = db.Employees.Where(x => x.Empid == id).FirstOrDefault();
            if (result != null)
            {
                db.Employees.Remove(result); // remove from DbSet
                res = db.SaveChanges();
            }

            return res;
        }

        public Employee GetEmployeeByEmpid(int id)
        {
            var result = db.Employees.Where(x => x.Empid == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return db.Employees.ToList();
        }

        public int UpdateEmployee(Employee employee)
        {
            int res = 0;


            var result = db.Employees.Where(x => x.Empid == employee.Empid).FirstOrDefault();

            if (result != null)
            {
                result.Name = employee.Name; // book contains new data, result contains old data
                result.Email = employee.Email;
                result.Salary = employee.Salary;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }
    }
}
