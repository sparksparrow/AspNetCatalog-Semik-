﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models
{  
    public enum ProductItemType
    {
        [Display(Name = "Комбинезон")]
        Overalls,
        [Display(Name = "Платье")]
        Dress,
        [Display(Name = "Рубашка")]
        Shirt,
        [Display(Name = "Костюм")]
        Costume
    }

    public class ProductItem : EntityBase
    {
        public ProductItem() : base()
        {
            Title = "";
            DateAdded = DateTime.UtcNow;
            Price = 0;
            Discount = 0;
            TotalPrice = 0;
            Sizes = new List<Size>();
            Images = new List<Image>();
        }

        [Required(ErrorMessage = "Отсутствует тип товара")]
        [Display(Name = "Тип товара")]
        public ProductItemType ProductItemType { get; set; }

        [Required(ErrorMessage = "Отсутствует название товара")]
        [Display(Name = "Название товара")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Отсутствует цвет товара")]
        [Display(Name = "Цвет товара")]
        public string Color { get; set; }

        [Required(ErrorMessage = "Отсутствует цена товара")]
        [Display(Name = "Цена")]
        public double Price { get; set; }

        [Range(0, 100, ErrorMessage = "Недопустимая скидка")]
        [Display(Name = "Скидка")]
        public int Discount { get; set; }

        [Range(0, 1000000, ErrorMessage = "Недопустимая цена")]
        [Display(Name = "Цена со скидкой")]
        public double TotalPrice { get; set; }

        [Display(Name = "Размеры")]
        public virtual ICollection<Size> Sizes { get; set; } 

        [StringLength(5000, ErrorMessage = "Описание не может содержать больше 5000 символов")]
        [Display(Name = "Описание")]
        public string Description { get; set; }
                
        [Display(Name = "Картинки")]
        public virtual ICollection<Image> Images { get; set; }

        [Required(ErrorMessage = "Не указан артикул")]
        [Display(Name = "Артикул")]
        public string Article { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Дата")]
        public DateTime DateAdded { get; set; }        
     
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                ProductItem productItem = (ProductItem)obj;
                return
                    (
                      Id == productItem.Id
                    ); ;
            }
        }

        public override int GetHashCode()
        {
            return Tuple.Create(Id).GetHashCode();
        }
    }
}

