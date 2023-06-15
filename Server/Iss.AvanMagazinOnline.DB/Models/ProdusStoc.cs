using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;

namespace Iss.AvanMagazinOnline.DB.Models
{
    [Table("tProdusStoc")]
    public class ProdusStoc:ColoaneDefault
    {
        [Key]
        public int ProdusStocId { get; set; }
        [Required]

        public int ProdusIdCt { get; set; }
        [Required]
        [Column(TypeName = "decimal(9,2)")]
        public double Stoc { get; set; }
    }
}
