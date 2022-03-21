using BirlesikYazilimHackaton.DataAccess;
using BirlesikYazilimHackaton.Entity;
using BirlesikYazilimHackaton.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BirlesikYazilimHackaton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IMemoryDal<UretimOperayonBildirimleri> _data;

        public HomeController(ILogger<HomeController> logger, IMemoryDal<UretimOperayonBildirimleri> data)
        {
            _logger = logger;
            _data = data;
        }

        public IActionResult Index()
        {
            var result = _data.GetAll();
            return View(result);
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