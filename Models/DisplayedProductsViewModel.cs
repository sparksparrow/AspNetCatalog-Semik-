using GnomShop.Models.DbEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GnomShop.Models
{
    public class DisplayedProductsViewModel
    {
        public DisplayedProducts DisplayedProducts { get; set; }
        public IQueryable<ProductItem> DisplayedProductItems { get; set; }

        public DisplayedProductsViewModel(DisplayedProducts displayedProducts, IQueryable<ProductItem> productItems)
        {
            DisplayedProducts = displayedProducts;

            var arrayProducts = displayedProducts.Products != null ? JsonConvert.DeserializeObject<List<Guid>>(displayedProducts.Products) : new List<Guid>();
            
            DisplayedProductItems = productItems.Where(x => arrayProducts.Contains(x.Id));
            }
        }
}
