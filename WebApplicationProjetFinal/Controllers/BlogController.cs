using Microsoft.AspNetCore.Mvc;

namespace WebApplicationProjetFinal.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
