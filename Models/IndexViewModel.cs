using GnomShop.Models.DbEntities;
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
        public DisplayedProducts DisplayedProducts { get; private set; }

        public IndexViewModel(IQueryable<MainSliderContent> mainSliderContents, CategoriesOfTheMonth categoriesOfTheMonth, DisplayedProducts displayedProducts)
        {
            MainSliderContents = mainSliderContents;
            CategoriesOfTheMonth = categoriesOfTheMonth;
            DisplayedProducts = displayedProducts;
        }
    }
}
