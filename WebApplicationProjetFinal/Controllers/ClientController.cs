using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using WebApplicationProjetFinal.AppData.Services;
using WebApplicationProjetFinal.Models;

namespace WebApplicationProjetFinal.Controllers
{
    public class ClientController : Controller
    {

        private readonly IClientService _service;

        public ClientController(IClientService service) => _service = service;





        public async Task<IActionResult> Index()
        {
            var allClients = await _service.GetAll();
            return View(allClients);
        }


        // GET: Client/Create 
        public IActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClientID,Nom,MotdePasse,Email,Telephone,Adresse")] Client client)
        {
            if (ModelState.IsValid)
            {
                
                var existingClient = await _service.GetClientByEmailAsync(client.Email);

                if (existingClient != null)
                {
                    ModelState.AddModelError("Email", "Cet email est déjà utilisé.");
                    return View(client); 
                }

                
                bool clientAjoute = await _service.AddNewAsync(client);
                if (clientAjoute)
                {
                    return RedirectToAction("Index", "Shop"); 
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Erreur lors de l'ajout du client.");
                    return View(client); 
                }
            }

            
            return View(client);
        }







    }
}

