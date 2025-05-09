using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationProjetFinal.Models;

namespace WebApplicationProjetFinal.AppData.Services
{
    public interface IClientService
    {
        Task<Client?> GetClientByEmailAsync(string email);

        Task<IEnumerable<Client>> GetAll();

        //Task<Livre> GetByIdAsync(int id);
        Task<bool> AddNewAsync(Client client);

        //Task<Livre> UpdateAsync(int id, Livre livre);
        //Task<bool> DeleteAsync(int id);
    }
}
