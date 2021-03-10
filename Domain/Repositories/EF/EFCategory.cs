using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Domain.Repositories.EF
{
    public class EFCategory : ICategory
    {
        private readonly CatalogDbContext context;
        public EFCategory(CatalogDbContext context)
        {
            this.context = context;
        }
        public Category GetCategoryById(Guid id)
        {
            return context.Categories.AsNoTracking().SingleOrDefault(c=>c.Id==id);
        }

        public void SaveCategory(Category entity)
        {
            if (entity != null)
            {
                if (entity.Image == null)
                {
                    var categoty = GetCategoryById(entity.Id);
                    entity.Image = categoty.Image;
                }             
            }
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
