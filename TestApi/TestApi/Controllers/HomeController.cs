using System.Linq;
using System.Web.Mvc;
using TestApi.Models;
using TestApi.ViewModels;

namespace TestApi.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var viewModel = new GigViewModel
            {
                Gig = _context.Gigs.ToList(),
                Genre = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}