using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.Models
{
    public class DescripcionVehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVehiculo { get; set; }


        [ForeignKey("idPlaca")]
        [MaxLength(50)]
        [Required]
        public string idPlaca { get; set; }

        [ForeignKey("vStatus")]
        [Required]
        public bool vStatus { get; set; }



    }
}
