using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class CategoryM : BaseEntity
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = "Category ")]
        [Column(TypeName = "nvarchar(100)")]
        public string Category { get; set; } = string.Empty;

    }
}
