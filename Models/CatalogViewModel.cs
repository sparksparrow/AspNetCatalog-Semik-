using GnomShop.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Models
{
    public class CatalogViewModel
    {
        private static readonly int pageSize = 9;
        public ViewFilter<ProductItem> ViewFilterProductItems { get; private set; }
        public PaginatedList<ProductItem> PaginateProductItems { get; private set; }
        public IQueryable<ProductItem> ProductItems { get; private set; }
        public double MaxPrice { get; private set; }

        CatalogViewModel(ViewFilter<ProductItem> viewFilter, IQueryable<ProductItem> productItems, PaginatedList<ProductItem> paginateProductItems, double maxPrice) 
        {
            ViewFilterProductItems = viewFilter;
            ProductItems = productItems;            
            PaginateProductItems = paginateProductItems;            
            MaxPrice = maxPrice;
        }

        public static async Task<CatalogViewModel> CreateAsync(ViewFilter<ProductItem> viewFilter ,IQueryable<ProductItem> source, int pageIndex, string sortOrder)
        {
            var max = await source.MaxAsync(p => p.Price);
            var filteredSource = viewFilter.Filter(source);
            var sortedSource = SortOrder<ProductItem>.Create(filteredSource, sortOrder);            
            var paginateProductItems = await PaginatedList<ProductItem>.CreateAsync(sortedSource, pageIndex, pageSize);
            return new CatalogViewModel(viewFilter, source, paginateProductItems, max);
        }

    }
}
