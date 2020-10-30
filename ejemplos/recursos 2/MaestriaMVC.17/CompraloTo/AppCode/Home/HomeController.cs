using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CompraloTo.ViewModels;

namespace CompraloTo.Controllers
{
    [ActionAuthorize]
    public class HomeController : Controller
    {
        private readonly IAccountService _accountService;

        /// <summary>
        /// Constructor from IOC
        /// </summary>
        public HomeController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        
        /// <summary>
        /// Returns home page
        /// </summary>
        public ActionResult Index()
        {
            return View("HomeView");
        }



        /// <summary>
        /// Prints dropdown for user select language
        /// </summary>
        [AllowAnonymous]
        [ChildActionOnly]
        public ActionResult LanguagesDropdown()
        {
            return PartialView("LanguagesDropdown", new LanguagesDropdownViewModel()
            {
                Languages = _accountService.GetAvailableLanguages(),
                CurrentLanguage = _accountService.CurrentLanguage,
            });
        }


        /// <summary>
        /// Action for changing current language
        /// </summary>
        [Route("languageSelector")]
        [AllowAnonymous]
        public ActionResult LanguageSelector(string langCode)
        {
            if (!string.IsNullOrEmpty(langCode))
            {
                _accountService.SetCurrentLanguage(langCode);
            }

            string referrer = Request.UrlReferrer?.AbsoluteUri;
            bool redirectToRoot = string.IsNullOrEmpty(referrer) || Url.IsLocalUrl(Request.Url.AbsoluteUri);
            return Redirect(redirectToRoot ? "/" : referrer);
        }

    }
}