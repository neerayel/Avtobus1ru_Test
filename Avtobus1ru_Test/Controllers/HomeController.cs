using System.Diagnostics;
using Avtobus1ru_Test.Data.Interfaces;
using Avtobus1ru_Test.Models;
using Microsoft.AspNetCore.Mvc;

namespace Avtobus1ru_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILinkRepository _linkRepository;

        public HomeController(ILogger<HomeController> logger, ILinkRepository linkRepository)
        {
            _logger = logger;
            _linkRepository = linkRepository;
        }

        public IActionResult Index()
        {
            var linksData = _linkRepository.GetAllAsync();
            return View(linksData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
