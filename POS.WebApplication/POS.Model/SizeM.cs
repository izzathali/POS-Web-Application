using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class SizeM : BaseEntity
    {
        [Key]
        public int SizeId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Size { get; set; } = string.Empty;
    }
}
