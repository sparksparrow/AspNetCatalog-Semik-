using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models
{
    public enum ProductItemType
    {
        [Display(Name = "Костюм")]
        Costume,
        [Display(Name = "Платье")]
        Dress,
        [Display(Name = "Юбка")]
        Skirt
    }

    public class ProductItem : EntityBase
    {
        public ProductItem() : base()
        {
            Price = 0;
            Discount = 0;
            IsInStock = true;
            Sizes = new List<Size>();
            Images = new List<Image>();
            IsDisplayed = false;
            IsNovelty = false;
        }

        [Required(ErrorMessage = "Отсутствует тип товара")]
        [Display(Name = "Тип товара")]
        public ProductItemType ProductItemType { get; set; }

        [Required(ErrorMessage = "Отсутствует название товара")]
        [Display(Name = "Название товара")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Отсутствует цена товара")]
        [Display(Name = "Цена")]
        public double Price { get; set; }

        [Range(0, 100, ErrorMessage = "Недопустимая скидка")]
        [Display(Name = "Скидка")]
        public int Discount { get; set; }

        [Required(ErrorMessage = "Отсутствует статус о наличии товара")]
        [Display(Name = "В наличии")]
        public bool IsInStock { get; set; } 

        [Display(Name = "Размеры")]
        public virtual ICollection<Size> Sizes { get; set; } 

        [StringLength(5000, ErrorMessage = "Описание не может содержать больше 5000 символов")]
        [Display(Name = "Описание")]
        public string Description { get; set; }
                
        [Display(Name = "Картинки")]
        public virtual ICollection<Image> Images { get; set; } 

        [Required(ErrorMessage = "Отсутствует статус оторбажение на главной страницы товара")]
        [Display(Name = "Отображается на главной")]
        public bool IsDisplayed { get; set; }

        [Required(ErrorMessage = "Отсутствует статус новинки товара")]
        [Display(Name = "Новинка")]
        public bool IsNovelty { get; set; }
    }
}
