using GnomShop.Models.DbEntities;
using System.Threading.Tasks;

namespace GnomShop.Domain.Repositories.Interfaces
{
    public interface ICategoriesOfTheMonth
    {        
        Task<CategoriesOfTheMonth> GetCategoriesOfTheMonthAsync();
        void SaveCategoriesOfTheMonth(CategoriesOfTheMonth entity);
    }
}
