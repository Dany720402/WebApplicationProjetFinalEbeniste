using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using WebApplicationProjetFinal.AppData.Services;
using WebApplicationProjetFinal.Models;

namespace WebApplicationProjetFinal.Controllers
{
    public class ShopController : Controller
    {
       
            private readonly IMeubleService _service;

            public ShopController(IMeubleService service) => _service = service;

           



            public async Task<IActionResult> Index()
            {
                var allMeubles = await _service.GetAll();
                return View(allMeubles);
            }
        }
}
