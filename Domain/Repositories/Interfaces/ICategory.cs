using GnomShop.Models.DbEntities;
using System;

namespace GnomShop.Domain.Repositories.Interfaces
{
    public interface ICategory
    {
        Category GetCategoryById(Guid id);
        void SaveCategory(Category entity);
    }
}
