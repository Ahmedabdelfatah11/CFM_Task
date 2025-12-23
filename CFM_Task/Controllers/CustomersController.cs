using CFM_Task.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CFM_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CompanyContext _context;

        public CustomersController(CompanyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCustomersWithOrders()
        {
            var result = _context.Customers
                .SelectMany(
                    c => c.Orders.DefaultIfEmpty(),   // LEFT JOIN
                    (c, o) => new
                    {
                        Customer_Id = c.ID,
                        Customer_Name = c.Name,
                        Order_Id = o != null ? o.ID : null,
                        Amount = o != null ? (decimal?)o.Amount : null,
                        Product_Name = o != null ? o.Product.Name : null,
                        Total_Cost = o != null ? (decimal?)(o.Amount * o.Product.Cost) : null
                    }
                )
                .ToList();

            return Ok(result);
        }
    }
}
