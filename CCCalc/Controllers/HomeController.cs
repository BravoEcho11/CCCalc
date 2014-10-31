using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CCCalc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalcResult(CCCalc.Models.CaclModel viewModel)
        {
            //add the two values
            viewModel.numRes = (viewModel.numOne + viewModel.numTwo);

            return View(viewModel);
        }
    }
}