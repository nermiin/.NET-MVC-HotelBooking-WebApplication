using System.Web.Mvc;

namespace MACARENA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Route("about")]
        public ActionResult About()
        {
            return View();
        }


        [Route("turizm")]
        public ActionResult Turizim()
        {
            return View();
        }
    }


}