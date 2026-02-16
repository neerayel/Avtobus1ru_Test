using URLShortener.MidLogic.Models;

namespace URLShortener.MidLogic.Interfaces
{
    public interface ILinkService
    {
        Task<bool> CreateAsync(string longURL);
        Task<List<LinkModel>> GetAllAsync(string redirrectionURL);
        Task<LinkModel> GetByIdAsync(int id);
        Task<string> GetLongFromShortAsync(string shortURL);
        Task<bool> UpdateAsync(LinkModel item);
        Task<bool> DeleteAsync(int id);
    }
}
