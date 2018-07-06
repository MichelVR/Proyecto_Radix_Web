using Proyecto_RadixWeb.Models;
using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {

       radixEntities db = new radixEntities();

        public ActionResult Index()
        {
            
            
            if (User.IsInRole("Administrador"))
            {
                
                string empresa = HttpContext.Session["Empresa"].ToString();
                ViewBag.empresa = empresa;

                return View("DashBoardAdmin");

            }


            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
