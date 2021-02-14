using System.Linq;
using GnomShop.Models;

namespace GnomShop.Domain
{
    public class SortOrder<T> where T : ProductItem
    {        
        public static IQueryable<T> Create(IQueryable<T> source, string sortOrder)
        {
            switch (sortOrder)
            {
                case "price_desc":
                    source = source.OrderByDescending(p => p.TotalPrice);
                    break;
                case "price_asc":
                    source = source.OrderBy(p => p.TotalPrice);
                    break;
                case "discount_desc":
                    source = source.OrderByDescending(p => p.Discount);
                    break;
                default:
                    source = source.OrderByDescending(p => p.DateAdded);
                    break;
            }
            return source;
        }
    }
}
