using System.Linq;
using CompraloTo.Domain;

namespace CompraloTo.DB
{
    public interface IDbContext
    {
        void Add<T>(T theElement) where T : Aggregate;

        IQueryable<Customer> Customers(bool trackChanges = false);
        IQueryable<Order> Orders(bool trackChanges = false);
        IQueryable<ProductCategory> ProductCategories(bool trackChanges = false);
        IQueryable<Product> Products(bool trackChanges = false);


        void Remove<T>(T theElement) where T : Aggregate;
        void SaveChanges();
    }
}