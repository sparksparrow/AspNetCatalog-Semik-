using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GnomShop.Domain.Repositories.EF
{
    public class EFPageTitleRepository : IPageTitleRepository
    {
        private readonly CatalogDbContext context;

        public EFPageTitleRepository(CatalogDbContext context)
        {
            this.context = context;
        }

        public IQueryable<PageTitle> GetPageTitles()
        {
            return context.PageTitles;
        }

        public PageTitle GetPageTitleByCodeWord(string codeWord)
        {
            return context.PageTitles.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public PageTitle GetPageTitleById(Guid id)
        {
            return context.PageTitles.FirstOrDefault(x => x.Id == id);
        }

        public void SavePageTitle(PageTitle entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

        }

        public void DeletePageTitle(Guid id)
        {
            context.PageTitles.Remove(new PageTitle { Id = id });
            context.SaveChanges();
        }
    }
}
