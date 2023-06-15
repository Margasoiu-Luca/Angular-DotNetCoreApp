using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iss.AvanMagazinOnline.DB.Models
{
    [Table("tProducator")]
    public class Producator:ColoaneDefaultTabelaCt
    {
        [Column(TypeName = "int")]
        [Key]
        public int ProducatorId { get; set; }
        [Column(TypeName = "int")]
        public int? ProducatorIdCt { get; set; }

        public DateTime? DataInceput { get; set; }
        public DateTime? DataSfarsit { get; set; }

        [Column(TypeName = "nvarchar(32)")]
        public string Nume { get; set; }

        [Column(TypeName = "nvarchar(32)")]
        public string Adresa { get; set; }

        public ICollection<Produs> Produse { get; set; }


    }
}
