using DigitopiaQuest.Areas.Identity.Data;
using DigitopiaQuest.Data;
using DigitopiaQuest.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DigitopiaQuest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<DigitopiaQuestUser> _userManager;
        public HomeController(ILogger<HomeController> logger, UserManager<DigitopiaQuestUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {           
            var user = await _userManager.GetUserAsync(User).ConfigureAwait(true);

            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}