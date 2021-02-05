using System;
using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models
{
    public class Size
    {
        public Size (double sizeValue)
        {
            SizeValue = sizeValue;
        }
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Range(1, 300, ErrorMessage = "Недопустимый размер")]
        [Display(Name = "Размер")]
        public double SizeValue { get; set; }

        public Guid ProductItemId { get; set; }
        public virtual ProductItem ProductItem { get; set; }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Size size = (Size)obj;
                return (SizeValue == size.SizeValue);
            }
        }

        public override int GetHashCode()
        {
            return Tuple.Create(SizeValue).GetHashCode();
        }
    }
}
