using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBookDataAccess.Data;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository :  Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext  _db;
        public ProductRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Product obj)
        {
           _db.Products.Update(obj);
        }
    }
}
