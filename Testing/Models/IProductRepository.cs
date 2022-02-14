using System;
using System.Collections.Generic;
using Testing.Models;
namespace Testing
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct(Product product);
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
    }
}
