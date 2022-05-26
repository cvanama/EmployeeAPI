using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public static class SampleEmployeeData
    {
        public static List<Employee> Employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "emp1"
            },
            new Employee
            {
                Id = 2,
                Name = "emp2"
            }
        };
    }
}
