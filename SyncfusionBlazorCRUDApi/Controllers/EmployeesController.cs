using Microsoft.AspNetCore.Mvc;
using SyncfusionBlazorCRUDApi.Data;
namespace SyncfusionBlazorCRUDApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> Employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Employee 1", Title = "Manager" , Age = 21 },
            new Employee { Id = 2, Name = "Employee 2", Title = "Developer" , Age = 30 }
        };

        [HttpGet("GetList")]
        public ActionResult<IEnumerable<Employee>> GetEmployees()
        {
            return Ok(Employees);
        }

        [HttpGet("GetByID")]
        public ActionResult<Employee> GetEmployee(int id)
        {
            var Employee = Employees.FirstOrDefault(i => i.Id == id);
            if (Employee == null)
                return NotFound();
            return Ok(Employee);
        }

        [HttpPost("Add")]
        public ActionResult<Employee> PostEmployee([FromBody] Employee newEmployee)
        {
            int newId = Employees.Count > 0 ? Employees.Max(i => i.Id) + 1 : 1;
            newEmployee.Id = newId;
            Employees.Add(newEmployee);
            return CreatedAtAction(nameof(GetEmployee), new { id = newEmployee.Id }, newEmployee);
        }

        [HttpPut("Update")]
        public ActionResult PutEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            var existingEmployee = Employees.FirstOrDefault(i => i.Id == id);
            if (existingEmployee == null)
                return NotFound();

            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Title = updatedEmployee.Title;
            existingEmployee.Age = updatedEmployee.Age;

            return NoContent();
        }

        [HttpDelete("Delete")]
        public ActionResult DeleteEmployee(int id)
        {
            var Employee = Employees.FirstOrDefault(i => i.Id == id);
            if (Employee == null)
                return NotFound();

            Employees.Remove(Employee);
            return NoContent();
        }
    }
}
