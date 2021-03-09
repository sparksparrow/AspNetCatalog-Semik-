using GnomShop.Domain.Repositories.Interfaces;

namespace GnomShop.Domain
{
    public class DataManager
    {
        public IPageTitleRepository Pages { get; set; }
        public IProductItemRepository ProductItems { get; set; }
        public ISizeRepository Sizes { get; set; }
        public IMainSliderContent MainSliderContent { get; set; }
        public ICategoriesOfTheMonth CategoriesOfTheMonth { get; set; }
        public IDisplayedProducts DisplayedProducts { get; set; }

        public DataManager(IPageTitleRepository page, IProductItemRepository productItems, ISizeRepository sizes, IMainSliderContent mainSliderContent, ICategoriesOfTheMonth categoriesOfTheMonth, IDisplayedProducts displayedProducts)
        {
            Pages = page;
            ProductItems = productItems;
            Sizes = sizes;
            MainSliderContent = mainSliderContent;
            CategoriesOfTheMonth = categoriesOfTheMonth;
            DisplayedProducts = displayedProducts;
        }

    }
}
