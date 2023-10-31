using WebApiDemo.Models;

namespace WebApiDemo.Services
{
    public interface IEmployeeSevice
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeByEmpid(int Empid);
        int AddEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(int Empid);
    }
}
