using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aplication.Data;


namespace Aplication.Service.Services
{
    public class ProductService : IProductService
    {
        private ProductDBEntities db = new ProductDBEntities();

        public Product GetProduct(int id)
        {
            return db.Product.Where(item => item.Id == id).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return db.Product.ToList();
        }

        public bool SaveProduct(Product product)
        {
            try
            {
                db.Product.Add(product);
                db.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool UpdateProduct(int id, Product product)
        {
            try
            {
                
            }
            throw new NotImplementedException();
        }
        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

    }
}