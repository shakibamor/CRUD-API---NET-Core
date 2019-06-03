using Microsoft.AspNetCore.Mvc;
using Practice.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;



namespace Practice.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly ASPNETContext _context;

        public EmployeeController(ASPNETContext context)
        {
           
            _context = context;
        }
        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList = _context.Employees.OrderBy(a => a.Name).ToList();
           
            return employeeList;
        }

        // GET: api/Employee/5
        [HttpGet("{id}")]
        public async Task<Employee> GetEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            return employee;
        }
    }
}