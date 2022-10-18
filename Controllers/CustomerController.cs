using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
