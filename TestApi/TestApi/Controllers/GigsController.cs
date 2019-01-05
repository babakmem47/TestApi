using System.Linq;
using System.Web.Http;
using TestApi.Models;

namespace TestApi.Controllers
{
    public class GigsController : ApiController
    {
        private ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetGigs()
        {
            var gigList = _context.Gigs.ToList();

            return Ok(gigList);
        }
    }
}
