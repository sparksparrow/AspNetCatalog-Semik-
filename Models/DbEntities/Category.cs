using GnomShop.Services;
using System;
using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models.DbEntities
{
    public class Category
    {
        [Required]
        public Guid Id { get; set; }
        [Display(Name = "Категория")]
        public PluralProductItemTypes ProductItemType { get; set; }
        [Display(Name = "Картинка")]
        public byte[] Image { get; set; }

        [StringLength(10)]
        [Display(Name = "Расширение картинки")]
        public string Extension { get; set; }

        [StringLength(300)]
        [Display(Name = " SEO альтернативное название")]
        public string Alt { get; set; }

        public Guid CategoriesOfTheMonthId { get; set; }
        public virtual CategoriesOfTheMonth CategoriesOfTheMonth { get; set; }
    }
}
