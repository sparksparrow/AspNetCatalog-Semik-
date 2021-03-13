using System.ComponentModel.DataAnnotations;

namespace GnomShop.Models
{
    public class PageTitle : EntityBase
    {
        public PageTitle() : base() { }
        [Required]
        [StringLength(30)]
        public string CodeWord { get; set; }
    }
}
