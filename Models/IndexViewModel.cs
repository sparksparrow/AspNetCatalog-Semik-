using GnomShop.Models.DbEntities;
using System.Linq;

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
