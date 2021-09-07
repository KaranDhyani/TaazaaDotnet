using System;
using System.Collections.Generic;

namespace EmployeeService.Models
{
    public class EmployeeData
    {
        public List<Employee> Empdetails()
        {
            List<Employee> Object = new List<Employee>();
            Object.Add(new Employee
            {
                phno = 4498768,
                name = "Rahul"
            });
            Object.Add(new Employee
            {
                phno = 5643543,
                name = "Gurpreet"
            });
            Object.Add(new Employee
            {
                phno = 987632,
                name = "Salman"
            });

            return Object;
        }
    }
}