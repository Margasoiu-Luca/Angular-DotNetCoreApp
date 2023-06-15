using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iss.AvanMagazinOnline.DB.Models
{
    [Table("tComanda")]
    public class Comanda:ColoaneDefault
    {
        [Key]
        public int ComandaId { get; set; }


        [Column(TypeName = "nvarchar(128)")]
        [Required]
        public string Numar { get; set;}

        [DefaultValue("getdate()")]
        public DateTime DataComanda { get; set; }


        [Column(TypeName = "decimal(28,4)")]
        public Decimal CostTotalProduse { get; set; }

        [Column(TypeName = "decimal(28,4)")]
        public Decimal CostLivrare { get; set; }

        public int CumparatorId { get; set; }

        public Cumparator Cumparator { get; set; }
    }
}
