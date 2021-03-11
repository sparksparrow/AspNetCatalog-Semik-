using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GnomShop.Domain.Repositories.EF
{
    public class EFCategoriesOfTheMonth : ICategoriesOfTheMonth
    {
        private readonly CatalogDbContext context;
        public EFCategoriesOfTheMonth(CatalogDbContext context)
        {
            this.context = context;
        }
        public async Task<CategoriesOfTheMonth> GetCategoriesOfTheMonthAsync()
        {
            return await context.CategoriesOfTheMonths.Include(c => c.Categories).SingleOrDefaultAsync();
        }

        public async Task<CategoriesOfTheMonth> GetCategoriesOfTheMonthAsNoTrackingAsync()
        {
            return await context.CategoriesOfTheMonths.Include(c => c.Categories).AsNoTracking().SingleOrDefaultAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(Guid id)
        {
            return await context.Categories.SingleOrDefaultAsync(c=>c.Id==id);
        }

        public void SaveCategoriesOfTheMonth(CategoriesOfTheMonth entity)
        {            
            context.Entry(entity).State = EntityState.Modified;   
            context.SaveChanges();
        }
    }
}
