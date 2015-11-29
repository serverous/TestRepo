using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicineStore.Controllers
{
    public class MedicineController : Controller
    {
        //
        // GET: /Medicine/

        public ActionResult Index()
        {
            return View();
        }

    }
}
