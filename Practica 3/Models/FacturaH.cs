using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.Models
{
    public class FacturaH
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFacturaH { get; set; }

        [ForeignKey("idCliente")]
        [Required]
        public int idCliente { get; set; }

        [ForeignKey("idProducto")]
        [Required]
        public int idProducto { get; set; }

        public DateTime fventa { get; set; }


        [MaxLength(50)]
        [Required]
        public string mPago { get; set; }

        [MaxLength(11)]
        [Required]
        public string NCF { get; set; }



    }
}
