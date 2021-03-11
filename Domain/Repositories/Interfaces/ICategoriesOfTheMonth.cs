using GnomShop.Models.DbEntities;
using System;
using System.Threading.Tasks;

namespace GnomShop.Domain.Repositories.Interfaces
{
    public interface ICategoriesOfTheMonth
    {        
        Task<CategoriesOfTheMonth> GetCategoriesOfTheMonthAsync();
        Task<CategoriesOfTheMonth> GetCategoriesOfTheMonthAsNoTrackingAsync();
        void SaveCategoriesOfTheMonth(CategoriesOfTheMonth entity);
        Task<Category> GetCategoryByIdAsync(Guid id);
    }
}
