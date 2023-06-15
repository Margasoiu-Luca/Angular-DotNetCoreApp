using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Iss.AvanMagazinOnline.DB.Models
{
    [Table("tProdus")]
    public class Produs : ColoaneDefaultTabelaCt
    {
        [Key]
        [Column(TypeName = "int")]
        public int ProdusId { get; set; }
        public int? ProdusIdCt { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string? DenumireProdus { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public float CostProdus { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string DescriereProdus { get; set; }

        public int CategorieProdusId { get; set; }

        public CategorieProdus CategorieProdus { get; set;}



        public int ProducatorId { get; set; }

        public Producator Producator { get; set; }
    }
}
