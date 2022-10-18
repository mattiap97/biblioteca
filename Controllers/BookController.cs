using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
