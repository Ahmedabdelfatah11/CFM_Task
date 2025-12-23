using CFM_Task.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CFM_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly CompanyContext _context;

        public SalaryController(CompanyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetSalarySumByDepartment()
        {
            var result = _context.Departments
                .Select(d => new
                {
                    Department_Id = d.ID,
                    Department_Name = d.Name,
                    Sum_Salary = d.Employees.Sum(e => (decimal?)e.Salary) ?? 0
                })
                .ToList();

            return Ok(result);
        }
    }
}
