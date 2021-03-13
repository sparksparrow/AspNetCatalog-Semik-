using System;
using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models.DbEntities
{
    public class DisplayedProducts
    {
        [Required]
        public Guid Id { get; set; }
        [StringLength(300)]
        [Display(Name = "Оглавление")]
        public string Title { get; set; }
        [StringLength(500)]
        [Display(Name = "Описание")]
        public string Description { get; set; }
        [Display(Name = "Продукты на главной")]
        public string Products { get; set; }
    }
}
