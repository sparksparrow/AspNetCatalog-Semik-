using System;
using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models
{
    public class Image
    {
        public Image(string name = "")
        {
            Name = name;
            Alt = System.IO.Path.GetFileNameWithoutExtension(name);
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Название картинки")]
        public string Name { get; set; }

        [StringLength(300)]
        [Display(Name = " SEO альтернативное название")]
        public string Alt { get; set; }

        public Guid ProductItemId { get; set; }
        public virtual ProductItem ProductItem { get; set; }
    }
}
