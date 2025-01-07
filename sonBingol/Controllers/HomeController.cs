using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sonBingol.Models.Siniflar;


namespace sonBingol.Controllers
{
    public class HomeController : Controller
    {
        private string connectionString = "Server=(localdb)MSSQLLocalDB;Database=sonBingol.Models.Siniflar.Context;Trusted_Connection=True;";
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
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