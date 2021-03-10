using GnomShop.Models.DbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Domain.Repositories.Interfaces
{
    public interface ICategory
    {
        Category GetCategoryById(Guid id);
        void SaveCategory(Category entity);
    }
}
