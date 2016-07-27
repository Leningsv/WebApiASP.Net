using Aplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service.Services
{
    interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int id);
        Boolean SaveProduct(Product product);
        Boolean UpdateProduct(int id, Product product);
        Boolean DeleteProduct(int id);

    }
}
