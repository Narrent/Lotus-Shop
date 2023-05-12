using System.Collections.Generic;
using LotusShop.Domain.Entities;

namespace LotusShop.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void SaveProduct(Product product);
        Product DeleteProduct(int productId);
    }
}
