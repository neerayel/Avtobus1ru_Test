using URLShortener.MidLogic.Interfaces;
using URLShortener.MidLogic.Models;
using URLShortener.Models;
using LX.TestPad.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.Diagnostics;

namespace URLShortener.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILinkService _linkService;

        public HomeController(ILogger<HomeController> logger, ILinkService linkService)
        {
            _logger = logger;
            _linkService = linkService;
        }


        public async Task<IActionResult> Index(bool? prevOpResult = null)
        {
            ViewBag.PrevOpResult = prevOpResult;
            string redirrectionURL = $"{Request.Scheme}://{Request.Host}/r/";
            var linksData = await _linkService.GetAllAsync(redirrectionURL);
            return View(linksData);
        }


        [HttpPost]
        public async Task<IActionResult> CreateNewLink(string longURL)
        {
            bool isSuccessful = await _linkService.CreateAsync(longURL);
            return RedirectToAction(nameof(Index), new { prevOpResult=isSuccessful });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateLink(LinkModel linkModel)
        {
            bool isSuccessful = await _linkService.UpdateAsync(linkModel);
            return RedirectToAction(nameof(Index), new { prevOpResult = isSuccessful });
        }


        public async Task<IActionResult> DeleteLink(int id)
        {
            bool isSuccessful = await _linkService.DeleteAsync(id);
            return RedirectToAction(nameof(Index), new { prevOpResult = isSuccessful });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
