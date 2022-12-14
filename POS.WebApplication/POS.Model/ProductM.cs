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
        [Required(ErrorMessage = "ProductCode is required")]
        [Display(Name = "Product Code ")]
        [Column(TypeName = "nvarchar(200)")]
        public string ProductCode { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(200)")]
        public string? Barcode { get; set; }
        [Display(Name = "Product Name")]
        [Column(TypeName = "nvarchar(400)")]
        public string ProductName { get; set; } = string.Empty;
        [Display(Name = "Description")]
        public string? ProductDescription { get; set; }
        [Display(Name = "Unit Cost")]
        public decimal UnitCost { get; set; }
        [Display(Name = "Cost Code")]
        public string? CostCode { get; set; }
        [Display(Name = "Selling Price")]
        public decimal SellingPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal StockQty { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Unit is required")]
        public int UnitId { get; set; }
        public string? Zip { get; set; }

        public int? BrandId { get; set; }
        public int? SizeId { get; set; }
        public int? ColourId { get; set; }

        public CategoryM? category { get; set; }
        public UnitM? unit { get; set; }
        public BrandM? brand { get; set; }
        public SizeM? size { get; set; }
        public ColourM? colour { get; set; }
    }
}
