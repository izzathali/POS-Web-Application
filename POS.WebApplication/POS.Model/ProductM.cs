using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class ProductM : BaseEntity
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string? Barcode { get; set; }
        [Display(Name = "Product Name")]
        [Column(TypeName = "nvarchar(400)")]
        public string ProductName { get; set; } = string.Empty;
        [Display(Name = "Description")]
        public string? ProductDescription { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Unit is required")]
        public int UnitId { get; set; }
        public int? BrandId { get; set; }
        public CategoryM? category { get; set; }
        public UnitM? unit { get; set; }
        public BrandM? brand { get; set; }
       
        //ICollection<SubProductM>? subproducts { get; set; }
        public virtual List<SubProductM> subproducts { get; set; } = new List<SubProductM>();
    }
}
