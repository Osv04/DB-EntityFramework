using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.Models
{
    public class Sucursal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idSucursal { get; set; }

        [ForeignKey("idPersonal")]
        [Required]
        public int idPersonal { get; set; }

        [MaxLength(50)]
        public int sNombre { get; set; }

        [MaxLength(11)]
        public int sTelefono { get; set; }


    }
}
