using GnomShop.Models.DbEntities;
using System;
using System.Threading.Tasks;

namespace GnomShop.Domain.Repositories.Interfaces
{
    public interface IDisplayedProducts
    {
        Task<DisplayedProducts> GetDisplayedProductsAsync();
        DisplayedProducts GetDisplayedProductsAsNoTracking();
        void SaveDisplayedProducts(DisplayedProducts entity);
        Task<DisplayedProducts> GetDisplayedProductsAsNoTrackingAsync();
        string GetDisplayedProducts();
        void RefreshDisplayedProducts(Guid id);
    }
}
