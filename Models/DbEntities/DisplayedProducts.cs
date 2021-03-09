﻿using System;
using System.Collections.Generic;
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
        [Display(Name = "Продукты")]
        public IList<ProductItem> Products { get; set; }
    }
}
