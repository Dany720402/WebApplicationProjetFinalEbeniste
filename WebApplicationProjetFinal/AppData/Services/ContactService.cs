using Microsoft.EntityFrameworkCore;
using WebApplicationProjetFinal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProjetFinal.AppData;

namespace WebApplicationProjetFinal.AppData.Services
{
    public class ContactService : IContactService
    {
        private readonly AppDbContext _context;

        public ContactService(AppDbContext context) => _context = context;


        public async Task<IEnumerable<Contact>> GetAll()
        {
            return await _context.Contacts
                                 .OrderBy(l => l.ContactID)
                                 .ToListAsync();
        }

        public async Task<bool> AddNewAsync(Contact contact)
        {
            bool contactExiste = await _context.Clients.AnyAsync(a => a.Nom == contact.Nom);
            if (contactExiste)
            {
                return false;
            }
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
            return true;
        }


    }
}
