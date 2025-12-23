using CFM_Task.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CFM_Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly CompanyContext _context;

        public OrdersController(CompanyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = _context.Orders
                .Include(o => o.Product)
                .OrderByDescending(o => o.ID)
                .Select(o => new
                {
                    Order_Id = o.ID,
                    Product_Id = o.Product_Id,
                    Product_Name = o.Product.Name
                })
                .ToList();

            return Ok(orders);
        }
    }
}
