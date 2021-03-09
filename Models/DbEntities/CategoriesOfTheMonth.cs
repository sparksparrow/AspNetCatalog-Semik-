using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models.DbEntities
{
    public class CategoriesOfTheMonth
    {
        [Required]
        public Guid Id { get; set; }
        [StringLength(300)]
        [Display(Name = "Название категории")]
        public string Title { get; set; }
        [StringLength(500)]
        [Display(Name = "Описание категории")]
        public string Description { get; set; }

        [Display(Name = "Категории")]
        public virtual IList<Category> Categories { get; set; }  

    }
}
