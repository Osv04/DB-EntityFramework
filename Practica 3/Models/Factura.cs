using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.Models
{
    public class Factura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFactura { get; set; }

        [ForeignKey("IdFacturaH")]
        [Required]
        public int IdFacturaH { get; set; }

        public int fCantidad { get; set; }

        public decimal Precio { get; set; }

        public decimal Itbis { get; set; }

        public int Descuento { get; set; }




    }
}
