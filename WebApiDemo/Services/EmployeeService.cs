using WebApiDemo.Models;
using WebApiDemo.Repositories;

namespace WebApiDemo.Services
{
    public class EmployeeService : IEmployeeSevice
    {

        private readonly IEmployeeRepository repo;
        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        public int AddEmployee(Employee employee)
        {
            return repo.AddEmployee(employee);
        }

        public int DeleteEmployee(int Empid)
        {
            return repo.DeleteEmployee(Empid);
        }

        public Employee GetEmployeeByEmpid(int Empid)
        {
            return repo.GetEmployeeByEmpid(Empid);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return repo.GetEmployees();
        }

        public int UpdateEmployee(Employee employee)
        {
            return repo.UpdateEmployee(employee);
        }
    }
}
