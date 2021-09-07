using EmployeeService.Models;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace EmployeeService.Controllers
{
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
        [HttpGet]
        public string item()
        {
            return "Laptop";
        }
        [HttpGet("Latest")]
        public string itemnew()
        {
            return "Tablet";
        }

         [HttpGet("Updated")]
        public Employee details()
        {
            Employee employee = new Employee();
            employee.phno = 977857;
            employee.name = "Karan";
            return employee;
        }

        [HttpGet("ListofEmp")]
        public List<Employee> Details()
        {
            EmployeeData employeeData = new EmployeeData();
            List<Employee> temp = employeeData.Empdetails();
            return temp;
        }
    }
}