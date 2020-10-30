using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompraloTo.DB;
using CompraloTo.Domain;

namespace CompraloTo.ViewModels
{
    public interface IProductQueryService
    {
        ProductDTO GetProductByID(int productID);
        List<ProductListDTO> GetProductList(GetProductListRequest request);
        IEnumerable<SelectListItem> GetProductCategories();
    }


    public class ProductQueryService : IProductQueryService
    {
        private readonly IDbContext _context;


        /// <summary>
        /// Constructor from IOC
        /// </summary>
        public ProductQueryService(IDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieve list of products
        /// </summary>
        /// <returns></returns>
        public List<ProductListDTO> GetProductList(GetProductListRequest request)
        {
            IQueryable<Product> query = _context.Products();

            if (request != null)
            {
            }

            return query
                .Select(c => new ProductListDTO()
                {

                    ID = c.ID,
                    name = c.name,

                    createDate = c.createDate,
                    description = c.description,
                    price = c.price

                }).ToList();

        }

        /// <summary>
        /// Retrieve product by ID
        /// </summary>
        public ProductDTO GetProductByID(int productID)
        {
            return _context
                .Products()
                .Where(c => c.ID == productID)
                .Select(c => new ProductDTO()
                {

                    ID = c.ID,
                    name = c.name,

                    createDate = c.createDate,
                    description = c.description,
                    price = c.price

                }).FirstOrDefault();
        }


        /// <summary>
        /// Retrieve list of product categories
        /// </summary>
        public IEnumerable<SelectListItem> GetProductCategories()
        {
            return _context
                .ProductCategories()
                .Select(c => new SelectListItem() {

                    Value = c.ID.ToString(),
                    Text = c.name

                })
                .ToList();
        }
    }
}