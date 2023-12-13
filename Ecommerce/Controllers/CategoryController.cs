using Ecommerce.DBContext;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _dbContext;

        public CategoryController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Category> categoriesList = _dbContext.Categories.ToList();

            return View(categoriesList);
        }

        public IActionResult Create() {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category formValues)
        { 
            if (ModelState.IsValid)
            {
                _dbContext.Categories.Add(formValues);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Create");
        }
    }
}
