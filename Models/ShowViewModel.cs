using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Models
{
    public class ShowViewModel
    {
        private readonly static int maxCountRealatedProducts = 12;
        private readonly static Random random = new Random();
        public ProductItem ProductItem { get; set; }
        public List<ProductItem> RelatedProdcuts { get; private set; }

        ShowViewModel(ProductItem productItem, List<ProductItem> relatedProdcuts)
        {
            ProductItem = productItem;
            RelatedProdcuts = relatedProdcuts;
        }

        private static int RandomNumber(int max)
        {
            return random.Next(0, max);
        }

        public static async Task<ShowViewModel> CreateAsync(ProductItem productItem, IQueryable<ProductItem> prodcutsItems)
        {
            var relatedProdcuts = await prodcutsItems.Where(p=>p.Name==productItem.Name && p.Color!=productItem.Color).ToListAsync();

            if(relatedProdcuts.Count < maxCountRealatedProducts)
            {
                var additionalProducts = await prodcutsItems
                    .Where(p=>p.ProductItemType==productItem.ProductItemType)                    
                    .ToListAsync();
                additionalProducts = additionalProducts.Except(relatedProdcuts).ToList();

                int countRealted = relatedProdcuts.Count();
                int countAdditional = additionalProducts.Count();

                while (maxCountRealatedProducts > countRealted && countAdditional > 0)
                {
                    var randomIndex = RandomNumber(countAdditional);
                    var addProduct = additionalProducts.ElementAt(randomIndex);
                    additionalProducts.RemoveAt(randomIndex);

                    relatedProdcuts.Add(addProduct);

                    countRealted = relatedProdcuts.Count();
                    countAdditional = additionalProducts.Count();
                }
            }
            return new ShowViewModel(productItem, relatedProdcuts);
        }
    }
}
