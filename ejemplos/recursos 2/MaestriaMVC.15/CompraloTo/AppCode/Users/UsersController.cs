using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CompraloTo.DB;
using CompraloTo.ViewModels;

namespace CompraloTo.AppCode.Controllers
{
    [RoutePrefix("users")]
    public sealed class UsersController : Controller
    {
        private readonly IUserQueryService _queryService;
        public UsersController(IUserQueryService queryService)
        {
            _queryService = queryService;
        }
       
    }
}
