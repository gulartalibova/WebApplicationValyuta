using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Valyuta
    {
        public int ID { get; set; }
        public string? AD  { get; set; }
        [Range(1,100)]
        [Column(TypeName ="decimal(18,4)")]
        public decimal Mezenne { get; set; }
        [Range(1, 100)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Alis { get; set; }
        [Range(1, 100)]
        [Column(TypeName = "decimal(18,4)")]   
        public decimal Satis { get; set; } 
        public DateTime Tarix { get; set; }

    }
}
