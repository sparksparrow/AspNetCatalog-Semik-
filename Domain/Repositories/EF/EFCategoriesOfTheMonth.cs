using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models.DbEntities;
using Microsoft.EntityFrameworkCore;
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

        public void SaveCategoriesOfTheMonth(CategoriesOfTheMonth entity)
        {
            if (entity.Categories != null)
            {
                foreach (var entityCategory in entity.Categories)
                {
                    context.Entry(entityCategory).State = EntityState.Modified;
                }
            }
            context.Entry(entity).State = EntityState.Modified;   
            context.SaveChanges();
        }
    }
}
