using Avtobus1ru_Test.MidLogic.Interfaces;
using Avtobus1ru_Test.MidLogic.Models;
using Avtobus1ru_Test.Data.Entities;
using Avtobus1ru_Test.Data.Interfaces;

namespace Avtobus1ru_Test.MidLogic.Services
{
    public class LinkService : ILinkService
    {
        private readonly ILinkRepository _linkRepository;
        public LinkService(ILinkRepository linkRepository)
        {
            _linkRepository = linkRepository;
        }

        public Task<LinkModel> CreateAsync(LinkModel item)
        {
            throw new NotImplementedException();
        }

        public Task<List<LinkModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LinkModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LinkModel>> GetLongFromShortAsync(string shortURL)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(LinkModel item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
