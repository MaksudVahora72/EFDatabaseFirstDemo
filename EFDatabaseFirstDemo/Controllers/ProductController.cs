using EFDatabaseFirstDemo.Data;
using EFDatabaseFirstDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFDatabaseFirstDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(TestEfdatabaseApprochContext context) : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> getAllProducts()
        {
            return await context.Products.ToListAsync();
        }
    }
}
