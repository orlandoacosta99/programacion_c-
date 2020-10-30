using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO;

using CompraloTo.ViewModels;


namespace CompraloTo.Controllers
{

    [RoutePrefix("cart")]
    public sealed class CartController : Controller
    {
        private readonly ICartService _cartService;

        /// <summary>
        /// Constructor from IOC
        /// </summary>
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }


        [Route("add")]
        [HttpPost]
        public ActionResult AddProductToCart(int productID)
        {
            _cartService.AddProductToCart(productID);

            return new JsonResult(){
                Data = _cartService.GetCartList().Count
            };
        }


        [Route("remove")]
        [HttpPost]
        public ActionResult RemoveProductFromCart(int productID)
        {
            _cartService.RemoveProductFromCart(productID);

            return new JsonResult()
            {
                Data = _cartService.GetCartList().Count
            };
        }


    }
}
