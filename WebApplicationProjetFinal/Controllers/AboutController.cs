using Microsoft.AspNetCore.Mvc;

namespace WebApplicationProjetFinal.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
