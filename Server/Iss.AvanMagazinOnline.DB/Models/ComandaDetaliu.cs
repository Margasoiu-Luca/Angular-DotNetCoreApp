using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iss.AvanMagazinOnline.DB.Models
{
    [Table("tComandaDetaliu")]
    internal class ComandaDetaliu:ColoaneDefault
    {
        [Key]
        public int ComandaDetaliuId { get; set; }


    }
}
