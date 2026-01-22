using Microsoft.AspNetCore.Mvc;
using WebApplication8.Data;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        private readonly DewiDbContext _context;
        public HomeController(DewiDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.products.Where(c => !c.IsDeleted));

        }
    }
}
