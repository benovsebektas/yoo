using Microsoft.AspNetCore.Mvc;
using yoo.DAL;
using yoo.Models;

namespace yoo.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> category=_context.Categories.ToList();
            return View(category);
        }
    }
}
