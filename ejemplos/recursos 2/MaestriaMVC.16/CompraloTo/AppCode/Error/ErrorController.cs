using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompraloTo.AppCode.Error
{
    [RoutePrefix("error")]
    public class ErrorController : Controller
    {
        // GET: Error
        [Route("")]
        public ActionResult GenericError()
        {
            return View("GenericError");
        }

        [Route("internalError")]
        public ActionResult InternalError()
        {
            return View("InternalError");
        }

        [Route("notFound")]
        public ActionResult NotFound()
        {
            return View("NotFound");
        }

        [Route("accessDenied")]
        public ActionResult AccessDenied()
        {
            return View("AccessDenied");
        }
    }
}