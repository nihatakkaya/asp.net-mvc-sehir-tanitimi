using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sonBingol.Controllers
{

    [Authorize]
    public class IlcelerController : Controller
    {
        // GET: Ilceler
       
        public ActionResult Index()
        {
            return View();
        }
    }
}