using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models.DbEntities;
using Microsoft.EntityFrameworkCore;
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

        public void SaveDisplayedProducts(DisplayedProducts entity)
        {  
           context.Entry(entity).State = EntityState.Modified;
           context.SaveChanges();
        }
    }
}
