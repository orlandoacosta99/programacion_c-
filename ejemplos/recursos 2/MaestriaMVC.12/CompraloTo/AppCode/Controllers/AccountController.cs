using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using CompraloTo.ViewModels;

namespace CompraloTo.Controllers
{

    [RoutePrefix("account")]
    public sealed class AccountController : Controller
    {
        private readonly IUserCommandService _cmdService;
        public AccountController(IUserCommandService cmdService)
        {
            _cmdService = cmdService;
        }



        /// <summary>
        /// Register new user
        /// </summary>
        [HttpGet]
        [Route("register")]
        public ActionResult Register()
        {
            return View("Register");
        }

        /// <summary>
        /// Post register new user
        /// </summary>
        [HttpPost]
        [Route("register")]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _cmdService.RegisterUser(new RegisterUserCommand()
                    {

                        email = model.email,
                        password = model.password,
                        confirm = model.confirm,

                    });

                    return RegisterSuccess();

                }
                catch (Exception ex)
                {
                    model.errorMessage = ex.Message;
                }

            }

            return View("Register", model);
        }


        /// <summary>
        /// Register success
        /// </summary>
        [HttpGet]
        [ChildActionOnly]
        [Route("register/success")]
        public ActionResult RegisterSuccess()
        {
            return View("RegisterSuccess");
        }


        /// <summary>
        /// Returns true if user name does not exists
        /// </summary>
        public JsonResult CheckUserNameExists(string email)
        {
            return new JsonResult()
            {
                //flip, since GUI requires true to be valid, and in this case, true means user exists and that's a validation error
                Data = !_cmdService.UserNameExists(email),
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }



        /// <summary>
        /// Activate existing user
        /// </summary>
        [HttpGet]
        [Route("activate")]
        public ActionResult Activate(ActivationEmailViewModel model)
        {
            try
            {
                _cmdService.ActivateUser(new ActivateUserCommand()
                {

                    email = model.email,
                    token = model.token,

                });

                model.successMessage = "Usuario activado correctamente";

            }
            catch(Exception ex)
            {
                model.errorMessage = ex.Message;
            }

            return View("ActivateResult", model);
        }




    }
}
