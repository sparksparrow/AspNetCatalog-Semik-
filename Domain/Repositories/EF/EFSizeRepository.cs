using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models;
using System.Linq;

namespace GnomShop.Domain.Repositories.EF
{
    class EFSizeRepository : ISizeRepository
    {
        private readonly CatalogDbContext context;

        public EFSizeRepository(CatalogDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Size> GetSizes()
        {
            return context.Sizes;
        }
    }
}
