using GnomShop.Models.DbEntities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GnomShop.Models
{
    public class IndexViewModel
    {
        public IQueryable<MainSliderContent> MainSliderContents { get; private set; }
        public CategoriesOfTheMonth CategoriesOfTheMonth { get; private set; }
        public DisplayedProductsViewModel DisplayedProductsViewModel { get; private set; }
        public IndexViewModel(IQueryable<MainSliderContent> mainSliderContents, CategoriesOfTheMonth categoriesOfTheMonth, DisplayedProductsViewModel displayedProducts)
        {
            MainSliderContents = mainSliderContents;
            CategoriesOfTheMonth = categoriesOfTheMonth;
            DisplayedProductsViewModel = displayedProducts;
        }        
    }
}
