using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;
using WebApplicationProjetFinal.AppData.Services;
using WebApplicationProjetFinal.Models;

namespace WebApplicationProjetFinal.Controllers
{
    public class ContactController : Controller
    {

        private readonly IContactService _service;

        public ContactController(IContactService service) => _service = service;





        public async Task<IActionResult> Index()
        {
            var allContacts = await _service.GetAll();
            return View(allContacts);
        }


        // GET: Client/Create
        public IActionResult Create()
        {
            return View();
            //return RedirectToAction("Index", "Shop");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContactID,Nom,Prenom,Email,Message")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                bool contactAjoute = await _service.AddNewAsync(contact);
                if (!contactAjoute)
                {
                    ModelState.AddModelError("Nom", "Ce client existe déjà");
                    return View(contact);
                }
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Index", "Pageprincipal");
            }
            return RedirectToAction("Index", "Pageprincipal");
            //return View(client);
        }







    }
}

