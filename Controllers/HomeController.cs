using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using yoo.DAL;
using yoo.Models;
using yoo.ViewModel;

namespace yoo.Controllers
{
    public class HomeController : Controller
    {

       private readonly AppDbContext _Context;

        public HomeController(AppDbContext context)
        {
            _Context = context;
        }

    

 

        public async Task<IActionResult> Index()

        {
            HomeVM homeVM = new HomeVM()
            {

                Categories = await _Context.Categories.ToListAsync(),
                Products=  await _Context.Products.ToListAsync(),
             };
            return View(homeVM);
        }

       
    }
}