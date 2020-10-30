using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CompraloTo.ViewModels;


namespace CompraloTo
{

    public class ActionAuthorizeAttribute : AuthorizeAttribute
    {

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            IAccountService accountService = ServiceInjector.Get<IAccountService>();

            bool isAuthenticated = accountService.IsAuthenticated;
            if (!isAuthenticated)
                return false;

            return accountService.IsInRoles(base.Roles);
        }

    }


}