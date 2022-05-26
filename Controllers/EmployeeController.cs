using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        //private List<Employee> Employees = new List<Employee>
        //{
        //    new Employee
        //    {
        //        Id = 1,
        //        Name = "emp1"
        //    },
        //    new Employee
        //    {
        //        Id = 2,
        //        Name = "emp2"
        //    }
        //};

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return SampleEmployeeData.Employees;
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var employee = SampleEmployeeData.Employees.FirstOrDefault( x => x.Id == id);
            
            if (employee != null)
                return employee;
            else
            {
                return new NotFoundObjectResult($"Employee with Id - {id} not found");
            }             
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            SampleEmployeeData.Employees.Add(employee);
            return employee;
        }        
    }
}
