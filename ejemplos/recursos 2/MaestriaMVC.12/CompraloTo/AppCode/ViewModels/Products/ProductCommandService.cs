using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using CompraloTo.DB;
using CompraloTo.Domain;


namespace CompraloTo.ViewModels
{
    public interface IProductCommandService
    {
        int CreateProduct(ProductDTO product);
        void UpdateProduct(ProductDTO product);
        void DeleteProduct(int productID);
    }



    public class ProductCommandService : IProductCommandService
    {
        private readonly IDbContext _context;

        /// <summary>
        /// Constructor from IOC
        /// </summary>
        public ProductCommandService(IDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create new product in the system
        /// </summary>
        public int CreateProduct(ProductDTO request)
        {
            

            Product product = new Product()
            {
                name = request.name,
                category = _context.ProductCategories(true).Where( pc=> pc.ID == request.categoryID).First(),
                createDate = DateTime.Now,
                description = request.description,
                price = request.price
            };

            _context.Add(product);

            _context.SaveChanges();


            return product.ID;
        }

        /// <summary>
        /// Update existing product in the system
        /// </summary>
        public void UpdateProduct(ProductDTO request)
        {
            Product product = _context.Products(true).Where(c => c.ID == request.ID).FirstOrDefault();

            Validate.NotNull(product, string.Format("Product with ID {0} not found", request.ID));

            product.name = request.name;
            product.description = request.description;
            product.price = request.price;

            _context.SaveChanges();
        }


        /// <summary>
        /// Delete existing product in the system
        /// </summary>
        public void DeleteProduct(int productID)
        {
            Product product = _context.Products(true).Where(c => c.ID == productID).FirstOrDefault();
            Validate.NotNull(product, string.Format("Product with ID {0} not found", productID));

            //remove from db
            _context.Remove(product);

            _context.SaveChanges();

        }


    }
}