using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProducto { get; set; }

        [ForeignKey("idVehiculo")]
        [Required]
        public int idVehiculo { get; set; }

        public DateTime tAlquiler { get; set; }

        public decimal pPrecio { get; set; }




    }
}
