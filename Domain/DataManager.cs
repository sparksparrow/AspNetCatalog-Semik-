using GnomShop.Domain.Repositories.Interfaces;

namespace GnomShop.Domain
{
    public class DataManager
    {
        public IPageTitleRepository Pages { get; set; }
        public IProductItemRepository ProductItems { get; set; }

        public DataManager(IPageTitleRepository page, IProductItemRepository productItems)
        {
            Pages = page;
            ProductItems = productItems;
        }
    }
}
