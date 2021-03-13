using GnomShop.Services;
using System;
using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models
{
    public abstract class EntityBase
    {
        public EntityBase()
        {
            Title = Config.CompanyName;
        }
        [Required]
        public Guid Id { get; set; }

        [StringLength(240, ErrorMessage = "Title cannot be longer than 240 characters.")]
        [Display(Name = "SEO метатег Title (Заголовок страницы)")]
        public string Title { get; set; }

        [StringLength(1000, ErrorMessage = "Description cannot be longer than 1000 characters.")]
        [Display(Name = "SEO метатег Description")]
        public string MetaDescription { get; set; }

        [StringLength(500, ErrorMessage = "Keywords cannot be longer than 500 characters.")]
        [Display(Name = "SEO метатег Keywords (Пример: \"Key1, Key2, Key3...\")")]
        public string MetaKeywords { get; set; }
    }
}
