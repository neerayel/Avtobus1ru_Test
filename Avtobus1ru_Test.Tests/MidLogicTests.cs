using Avtobus1ru_Test.MidLogic.Models;

namespace Avtobus1ru_Test.Tests
{
    public class MidLogicTests
    {
        static LinkModel testModel = new LinkModel()
        {
            Id = 0,
            LongURL = "https://www.fake-url.com",
            ShortURLKey = "ab593c12-0188-400f-8764-261e9d3efd35",
            ShortURL = "https://localhost:7251/shortlink/ab593c12-0188-400f-8764-261e9d3efd35",
            CreationDate = new DateTime(2026, 2, 13, 12, 0, 0),
            ClickCount = 1
        };

        static List<LinkModel> linkEntities = new List<LinkModel> { testModel };


        [Fact]
        public async Task CreateTest()
        {
            Assert.True(false);
        }

        [Fact]
        public async Task GetAllTest()
        {
            Assert.True(false);
        }

        [Fact]
        public async Task GetByIdTest()
        {
            Assert.True(false);
        }

        [Fact]
        public async Task GetLongFromShortTest()
        {
            Assert.True(false);
        }

        [Fact]
        public async Task GetShortFromLongTest()
        {
            Assert.True(false);
        }

        [Fact]
        public async Task UpdateTest()
        {
            Assert.True(false);
        }

        [Fact]
        public async Task DeleteTest()
        {
            Assert.True(false);
        }
    }
}
