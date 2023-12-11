using Microsoft.AspNetCore.Mvc;

namespace CRUDAPP.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
