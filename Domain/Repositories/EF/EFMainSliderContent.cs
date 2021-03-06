﻿using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
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
        public IQueryable<MainSliderContent> GetMainSliderContentsAsNoTracking()
        {
            return context.MainSliderContents.AsNoTracking();
        }

        public MainSliderContent GetMainSliderContentByIdAsNoTracking(Guid id)
        {
            return context.MainSliderContents.AsNoTracking().FirstOrDefault(m=>m.Id==id);
        }

        public void SaveMainSliderContent(MainSliderContent entity)
        {
            if (entity.Image == null)
            {                
                entity.Image = GetMainSliderContentByIdAsNoTracking(entity.Id).Image;
            }
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
            
        }

    }
}
