using CRUDAPP.DBContext;
using CRUDAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAPP.Controllers
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
    }
}
