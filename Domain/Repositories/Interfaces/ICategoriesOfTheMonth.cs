using GnomShop.Models.DbEntities;
using System;
using System.Threading.Tasks;

namespace GnomShop.Domain.Repositories.Interfaces
{
    public interface ICategoriesOfTheMonth
    {        
        Task<CategoriesOfTheMonth> GetCategoriesOfTheMonthAsync();
        void SaveCategoriesOfTheMonthAsync(CategoriesOfTheMonth entity);
        Task<Category> GetCategoryByIdAsync(Guid id);
    }
}
