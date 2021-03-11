using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models.DbEntities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Domain.Repositories.EF
{
    public class EFDisplayedProducts : IDisplayedProducts
    {
        private readonly CatalogDbContext context;
        public EFDisplayedProducts(CatalogDbContext context)
        {
            this.context = context;
        }
        public async Task<DisplayedProducts> GetDisplayedProductsAsync()
        {
            return await context.DisplayedProducts.SingleOrDefaultAsync();
        }
        public string GetDisplayedProducts()
        {
            return context.DisplayedProducts.AsNoTracking().SingleOrDefault().Products;
        }

        public async Task<DisplayedProducts> GetDisplayedProductsAsNoTrackingAsync()
        {
            return await context.DisplayedProducts.AsNoTracking().SingleOrDefaultAsync();
        }
        public void SaveDisplayedProducts(DisplayedProducts entity)
        {  
           context.Entry(entity).State = EntityState.Modified;
           context.SaveChanges();
        }
    }
}
