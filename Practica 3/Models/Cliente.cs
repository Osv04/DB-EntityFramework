using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCliente { get; set; }

        [ForeignKey("cCedula")]
        [Required]
        public int cCedula { get; set; }

        [ForeignKey("idSucursal")]
        public int idSucursal { get; set; }
 
        [MaxLength(09)]
        public string cRNC { get; set; }

    }
}
