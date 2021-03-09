using System;
using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models.DbEntities
{
    public class MainSliderContent
    { 
        [Required]
        public Guid Id { get; set; }
        [StringLength(300)]
        [Display(Name = "Оглавление")]
        public string Title { get; set; }

        [StringLength(300)]
        [Display(Name = "Допольнительный заголовок")]
        public string SubTitle { get; set; }

        [StringLength(500)]
        [Display(Name = "Описание")]
        public string Description { get; set; }

        [Display(Name = "Картинка")]
        public byte[] Image { get; set; }

        [StringLength(300)]
        [Display(Name = " SEO альтернативное название")]
        public string Alt { get; set; }

        [StringLength(10)]
        [Display(Name = "Расширение картинки")]
        public string Extension { get; set; }
    }
}
