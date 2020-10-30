using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CompraloTo.ViewModels;


namespace CompraloTo.Controllers
{
    public class EmailController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("ActivationTemplate", new ActivationEmailViewModel() {

                email = "mopicus@gmail.com", 
                token = "30f16e522c3e417c9425d52b1753a2e6"

            });
        }
    }
}