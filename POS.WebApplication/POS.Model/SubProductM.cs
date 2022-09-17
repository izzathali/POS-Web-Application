using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class SubProductM : BaseEntity
    {
        [Key]
        public int SubProductId { get; set; }
        public int ProductId { get; set; }
        
        [Required(ErrorMessage = "ProductCode is required")]
        [Display(Name = "Product Code ")]
        [Column(TypeName = "nvarchar(200)")]
        public string ProductCode { get; set; } = string.Empty;
        [Display(Name = "Unit Cost")]
        public decimal UnitCost { get; set; }
        [Display(Name = "Cost Code")]
        public string? CostCode { get; set; }
        [Display(Name = "Selling Price")]
        public decimal SellingPrice { get; set; }
        public decimal? Discount { get; set; }
        public decimal StockQty { get; set; }
        public string? Zip { get; set; }
        public int? SizeId { get; set; }
        public int? ColourId { get; set; }

        public ProductM? product { get; set; }
        public SizeM? size { get; set; }
        public ColourM? colour { get; set; }
    }
}
