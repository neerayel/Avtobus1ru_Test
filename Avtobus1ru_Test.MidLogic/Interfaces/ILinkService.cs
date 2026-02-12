using Avtobus1ru_Test.MidLogic.Models;

namespace Avtobus1ru_Test.MidLogic.Interfaces
{
    public interface ILinkService : IService<LinkModel>
    {
        Task<List<LinkModel>> GetLongFromShortAsync(string shortURL);
    }
}
