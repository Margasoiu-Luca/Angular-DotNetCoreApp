using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iss.AvanMagazinOnline.DB.Models
{
    [Table("tCumparator")]
    public class Cumparator: ColoaneDefaultTabelaCt
    {
        [Key]
        public int CumparatorId { get; set; }

        public int? CumparatorIdCt { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Nume { get;set; }

        [Column(TypeName = "nvarchar(32)")]
        public string? Prenume { get; set; }

        [Phone]
        [Column(TypeName = "nvarchar(32)")]
        public string TelefonMobil { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        public string Email { get; set; }

        [Column(TypeName = "tinyint")]
        public int TipPersoana { get; set; }

        public DateTime DataNastere { get; set; }


        [Column(TypeName = "nvarchar(32)")]
        public string? CNP { get; set; }

        public ICollection<Comanda> Comenzi { get; set; }
    }
}
