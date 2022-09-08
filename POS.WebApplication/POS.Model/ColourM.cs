using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class ColourM : BaseEntity
    {
        [Key]
        public int ColourId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string ColourCode { get; set; } = string.Empty;
    }
}
