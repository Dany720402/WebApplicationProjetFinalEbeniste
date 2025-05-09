using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationProjetFinal.Models;

namespace WebApplicationProjetFinal.AppData.Services
{
    public interface IContactService
    {
        // Task<IEnumerable<Auteur>> GetAllAuteursAsync();

        Task<IEnumerable<Contact>> GetAll();

        //Task<Livre> GetByIdAsync(int id);
        Task<bool> AddNewAsync(Contact contact);

        //Task<Livre> UpdateAsync(int id, Livre livre);
        //Task<bool> DeleteAsync(int id);
    }
}
