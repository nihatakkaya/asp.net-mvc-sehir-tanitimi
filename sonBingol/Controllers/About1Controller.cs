using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sonBingol.Models.Siniflar;

namespace sonBingol.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c=new Context();

        [Authorize]
        public ActionResult Index()
        {
            var degerler=c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}