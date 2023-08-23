using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace Employee.Assignment.Controllers
{
    [ApiController]
    [Route("api/printandaddemployee")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employeeslis = new List<Employee>();

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return employeeslis;
        }

        [HttpPost]
        public ActionResult Post(Employee employee)
        {
            employeeslis.Add(employee);
            return CreatedAtAction(nameof(Get), new { id = employee.Id }, employee);
        }
    }
}
