using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iss.AvanMagazinOnline.DB.Models
{
    public class ColoaneDefault
    {
        public DateTime? IData { get; set; }

        [Column(TypeName = "nvarchar(32)")]
        public string? ICalculator { get; set; }

        [Column(TypeName = "nvarchar(32)")]
        public string? IUtilizator { get; set; }

        public DateTime? UData { get; set; }

        [Column(TypeName = "nvarchar(32)")]
        public string? UCalculator { get; set; }

        [Column(TypeName = "nvarchar(32)")]
        public string? UUtilizator { get; set; }

        [Timestamp]
        public byte[] Rv { get; set; }
    }
}
