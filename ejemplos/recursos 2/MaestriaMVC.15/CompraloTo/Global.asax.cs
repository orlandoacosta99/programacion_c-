using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace CompraloTo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }


        protected void Application_Error()
        {
            Exception ex = this.Server.GetLastError();

            ILogService logService = ServiceInjector.Get<ILogService>();
            logService.LogError(ex.ToString());
        }


        /// <summary>
        /// Application end request, fix Forms authentication redirect issue
        /// </summary>
        protected void Application_EndRequest()
        {
            var context = new HttpContextWrapper(this.Context);

            // If we're an ajax request and forms authentication caused a 302, 
            // then we actually need to do a 401
            if (FormsAuthentication.IsEnabled && context.Response.StatusCode == 302/* && context.Request.IsAjaxRequest()*/)
            {
                string loc = context.Response.RedirectLocation;
                if (context.Response.RedirectLocation != null)
                {
                    context.Response.Clear();
                    context.Response.StatusCode = 401;
                }

                context.Response.SuppressFormsAuthenticationRedirect = true;
            }
        }



    }
}
