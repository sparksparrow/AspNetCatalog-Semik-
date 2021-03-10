using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace GnomShop.Domain.Repositories.EF
{
    public class EFMainSliderContent : IMainSliderContent
    {
        private readonly CatalogDbContext context;
        public EFMainSliderContent(CatalogDbContext context)
        {
            this.context = context;
        }
        public IQueryable<MainSliderContent> GetMainSliderContents()
        {
            return context.MainSliderContents;
        }

        public MainSliderContent GetMainSliderContentById(Guid id)
        {
            return context.MainSliderContents.AsNoTracking().FirstOrDefault(m=>m.Id==id);
        }

        public void SaveMainSliderContent(MainSliderContent entity)
        {
            if (entity.Image == null)
            {                
                entity.Image = GetMainSliderContentById(entity.Id).Image;
            }
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
            
        }

    }
}
