using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_3.Models
{
    public class Placa
    {
        [Key]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string idPlaca { get; set; }

        [MaxLength(50)]
        public string vColor { get; set; }

        public DateTime vAno { get; set; }

        [MaxLength(50)]
        public string vMarco { get; set; }

    }
}
