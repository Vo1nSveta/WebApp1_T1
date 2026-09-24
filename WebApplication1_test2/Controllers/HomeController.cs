using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp1_T1.Data;
using WebApp1_T1.Models;

namespace WebApp1_T1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly MyAppContext _context;

        public HomeController(ILogger<HomeController> logger, MyAppContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost]
        public IActionResult Index(WorkshopEquipmentModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var workshop = _context.Workshop.ToList();

            return View(workshop);
        }

        [HttpPost]
        public IActionResult Add(string workshop, string equipment)
        {
            var workshopeq = new Workshopeq
            {
                workshop = workshop,
                equipment = equipment
            };

            _context.Workshop.Add(workshopeq);
            _context.SaveChanges();

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
      
            return View();
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
