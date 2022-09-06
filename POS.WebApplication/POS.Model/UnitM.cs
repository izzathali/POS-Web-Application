using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model
{
    public class UnitM : BaseEntity
    {
        [Key]
        public int UnitId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Unit { get; set; } = string.Empty;
    }
}
