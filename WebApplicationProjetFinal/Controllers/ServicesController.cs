using Microsoft.AspNetCore.Mvc;

namespace WebApplicationProjetFinal.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
