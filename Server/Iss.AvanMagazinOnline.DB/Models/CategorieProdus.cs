using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iss.AvanMagazinOnline.DB.Models
{
    [Table("tnCategorieProdus")]
    public class CategorieProdus:ColoaneDefault
    {
        [Column(TypeName = "int")]
        [Key]
        public int CategorieProdusId { get; set; }
        [Column(TypeName = "nvarchar(128)")]
        public string DenumireCategorieProdus { get; set; }

        public ICollection<Produs> Produse { get; set; }
    }
}
