using GnomShop.Models;
using System.Linq;

namespace GnomShop.Domain.Repositories.Interfaces
{
    public interface ISizeRepository
    {
        IQueryable<Size> GetSizes();
    }
}
