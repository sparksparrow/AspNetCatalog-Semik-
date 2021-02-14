using GnomShop.Domain.Repositories.Interfaces;
using GnomShop.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

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
