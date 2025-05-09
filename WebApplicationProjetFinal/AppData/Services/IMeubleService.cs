using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationProjetFinal.Models;

namespace WebApplicationProjetFinal.AppData.Services
{
    public interface IMeubleService
    {
       // Task<IEnumerable<Auteur>> GetAllAuteursAsync();

        Task<IEnumerable<Meuble>> GetAll();

        Task<Meuble> GetByIdAsync(int id);

        //Task<bool> AddNewAsync(Livre livre);
        //Task<Livre> UpdateAsync(int id, Livre livre);
        //Task<bool> DeleteAsync(int id);
    }
}
