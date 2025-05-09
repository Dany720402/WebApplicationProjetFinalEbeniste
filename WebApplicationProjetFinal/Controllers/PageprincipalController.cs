using Microsoft.AspNetCore.Mvc;

namespace WebApplicationProjetFinal.Controllers
{
    public class PageprincipalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
