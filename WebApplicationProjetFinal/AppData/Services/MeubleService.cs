using Microsoft.EntityFrameworkCore;
using WebApplicationProjetFinal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationProjetFinal.AppData;

namespace WebApplicationProjetFinal.AppData.Services
{
    public class MeubleService : IMeubleService
    {
        private readonly AppDbContext _context;

        public MeubleService(AppDbContext context) => _context = context;


        public async Task<IEnumerable<Meuble>> GetAll()
        {
            return await _context.Meubles
                                 .OrderBy(l => l.MeubleID)
                                 .ToListAsync();
        }

        public async Task<Meuble?> GetByIdAsync(int id)
        {
            return await _context.Meubles.FindAsync(id);
        }


      //  public async Task<Livre> GetByIdAsync(int id)
        //{
          //  var result = await _context.Livres
            //                     .Include(l => l.Auteurs_Livres)
              //                   .FirstOrDefaultAsync(l => l.Id == id);
            //return result;
        //}


    }
}

