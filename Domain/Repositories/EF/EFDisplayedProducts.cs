using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models.DbEntities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public async void RefreshDisplayedProductsAsync(Guid id)
        {
            var existingModel = await GetDisplayedProductsAsNoTrackingAsync();

            var arrayProducts = existingModel.Products != null ? JsonConvert.DeserializeObject<List<Guid>>(existingModel.Products) : new List<Guid>();
            arrayProducts = arrayProducts.Where(p => p != default && p != id).ToList();            
            existingModel.Products = JsonConvert.SerializeObject(arrayProducts);

            SaveDisplayedProducts(existingModel);
        }
    }
}
