using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        void CreateProduct(string name, double price, int categoryID);
        public void DeleteProduct(int id);
    }
}
