using GnomShop.Domain.Repositories.Interfaces;

namespace GnomShop.Domain
{
    public class DataManager
    {
        public IPageTitleRepository Pages { get; set; }
        public IProductItemRepository ProductItems { get; set; }
        public ISizeRepository Sizes { get; set; }

        public DataManager(IPageTitleRepository page, IProductItemRepository productItems, ISizeRepository sizes)
        {
            Pages = page;
            ProductItems = productItems;
            Sizes = sizes;
        }
    }
}
