using URLShortener.Data;
using URLShortener.Data.Repositories;
using URLShortener.MidLogic.Models;
using URLShortener.MidLogic.Services;
using Microsoft.EntityFrameworkCore;

namespace URLShortener.Tests
{
    public class MidLogicTests
    {
        static LinkModel testModel = new LinkModel()
        {
            Id = 1,
            LongURL = "https://www.fake-url.com",
            ShortURLKey = "ab593c12-0188-400f-8764-261e9d3efd35",
            ShortURL = "",
            CreationDate = new DateTime(2026, 2, 13, 12, 0, 0),
            ClickCount = 1
        };
        static string testHostURL = "https://localhost:7251/r/";


        private LinkService GetService()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>().UseInMemoryDatabase(Guid.NewGuid().ToString());
            var context = new DataContext(optionsBuilder.Options);
            var repo = new LinkRepository(context);
            return new LinkService(repo);
        }

        [Fact]
        public async Task CreateTest()
        {
            var service = GetService();

            bool result = await service.CreateAsync(testModel.LongURL);

            Assert.True(result);
        }

        [Fact]
        public async Task GetAllTest()
        {
            var service = GetService();

            await service.CreateAsync(testModel.LongURL);
            var result = await service.GetAllAsync(testHostURL);

            Assert.Single(result);
        }

        [Fact]
        public async Task GetByIdTest()
        {
            var service = GetService();

            await service.CreateAsync(testModel.LongURL);
            var result = await service.GetByIdAsync(testModel.Id);

            Assert.NotNull(result);
        }

        [Fact]
        public async Task UpdateTest()
        {
            var service = GetService();

            await service.CreateAsync("EMPTY");
            await service.UpdateAsync(testModel);
            var result = await service.GetByIdAsync(testModel.Id);

            Assert.Equivalent(testModel, result);
        }

        [Fact]
        public async Task DeleteTest()
        {
            var service = GetService();

            await service.CreateAsync(testModel.LongURL);
            bool result = await service.DeleteAsync(testModel.Id);

            Assert.True(result);
        }
    }
}
