using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sonBingol.Models.Siniflar;


namespace sonBingol.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler=c.Blogs.ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult dilDegistir(string lang, string returnUrl)
        {
            Session["Dil"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }
    }
}