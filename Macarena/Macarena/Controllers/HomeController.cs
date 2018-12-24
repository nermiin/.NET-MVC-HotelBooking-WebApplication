using System.Globalization;
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
  
        public ActionResult About()
        {
            return View();
        }
  
        public ActionResult Turizim()
        {
            return View();
        }

        public ActionResult ChangeCulture(string lang, string returnUrl)
        {
            Session["Culture"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }
    }


}