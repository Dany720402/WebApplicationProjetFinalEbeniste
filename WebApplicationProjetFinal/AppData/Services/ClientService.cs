using Microsoft.EntityFrameworkCore;
using WebApplicationProjetFinal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProjetFinal.AppData;

namespace WebApplicationProjetFinal.AppData.Services
{
    public class ClientService : IClientService
    {
        private readonly AppDbContext _context;

        public ClientService(AppDbContext context) => _context = context;


        public async Task<IEnumerable<Client>> GetAll()
        {
            return await _context.Clients
                                 .OrderBy(l => l.ClientID)
                                 .ToListAsync();
        }


        public async Task<Client?> GetClientByEmailAsync(string email)
        {
            return await _context.Clients.FirstOrDefaultAsync(c => c.Email == email);
        }


        public async Task<bool> AddNewAsync(Client client)
        {
            bool clientExiste = await _context.Clients.AnyAsync(a => a.Nom == client.Nom);
            if (clientExiste)
            {
                return false;
            }
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return true;
        }


    }
}
