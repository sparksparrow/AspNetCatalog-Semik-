using System.ComponentModel.DataAnnotations;

namespace GnomShop.Services
{
    public enum PluralProductItemTypes
    {
        [Display(Name = "Комбинезоны")]
        Overalls,
        [Display(Name = "Платья")]
        Dress,
        [Display(Name = "Рубашки")]
        Shirt,
        [Display(Name = "Костюмы")]
        Costume
    }
}
