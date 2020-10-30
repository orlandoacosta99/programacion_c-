using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompraloTo.ViewModels
{
    public interface ICartService
    {
        List<int> GetCartList();
        void AddProductToCart(int productID);
        void RemoveProductFromCart(int productID);
    }


    /// <summary>
    /// We use this service to temporarily store products for shopping
    /// </summary>
    public sealed class CartService : ICartService
    {
        private const string SESSION_KEY = "Cart";

        public CartService()
        {

        }

        private List<int> Cart
        {
            get
            {
                //return cart, if not set create new one
                if (HttpContext.Current.Session[SESSION_KEY] == null)
                    HttpContext.Current.Session[SESSION_KEY] = new List<int>();
                return HttpContext.Current.Session[SESSION_KEY] as List<int>;
            }
            set
            {
                //always reassign session value
                HttpContext.Current.Session[SESSION_KEY] = value;
            }
        }

        /// <summary>
        /// Adds a new product to the cart
        /// </summary>
        public void AddProductToCart(int productID)
        {
            //get cart
            List<int> cart = this.Cart;

            //add product
            cart.Add(productID);

            //update cart
            this.Cart = cart;
        }


        /// <summary>
        /// Returns list of products in cart
        /// </summary>
        public List<int> GetCartList()
        {
            return this.Cart;
        }


        /// <summary>
        /// Remove product from cart
        /// </summary>
        public void RemoveProductFromCart(int productID)
        {
            //get cart
            List<int> cart = this.Cart;

            //remove product
            cart.Remove(productID);

            //update cart
            this.Cart = cart;
        }


    }
}