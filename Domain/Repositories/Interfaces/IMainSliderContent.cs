using GnomShop.Models.DbEntities;
using System;
using System.Linq;

namespace GnomShop.Domain.Repositories.Interfaces
{
    public interface IMainSliderContent
    {
        IQueryable<MainSliderContent> GetMainSliderContents();
        IQueryable<MainSliderContent> GetMainSliderContentsAsNoTracking();
        MainSliderContent GetMainSliderContentByIdAsNoTracking(Guid id);
        void SaveMainSliderContent(MainSliderContent entity);
    }
}
