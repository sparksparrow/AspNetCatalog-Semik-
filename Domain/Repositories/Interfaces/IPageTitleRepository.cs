using GnomShop.Models;
using System;
using System.Linq;

namespace GnomShop.Domain.Repositories.Interfaces
{
    public interface IPageTitleRepository
    {
        IQueryable<PageTitle> GetPageTitles();
        PageTitle GetPageTitleById(Guid id);
        PageTitle GetPageTitleByCodeWord(string codeWord);
        void SavePageTitle(PageTitle entity);
        void DeletePageTitle(Guid id);
    }
}
