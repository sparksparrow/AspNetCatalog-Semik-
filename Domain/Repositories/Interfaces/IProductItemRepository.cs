using GnomShop.Models;
using System;
using System.Linq;

namespace GnomShop.Domain.Repositories.Interfaces
{
    public interface IProductItemRepository
    {
        IQueryable<ProductItem> GetProducts();
        ProductItem GetProductById(Guid id);
        void SaveProductItem(ProductItem entity);
        void DeleteProduct(Guid id);
    }
}
