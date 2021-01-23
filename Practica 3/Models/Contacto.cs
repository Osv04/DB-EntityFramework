using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Practica_3.Models
{
    public class Contacto
    {
        [Key]
        [MaxLength(50)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string cCedula { get; set; }

        [MaxLength(50)]
        public string cNombre { get; set; }
        [Required(ErrorMessage = "Se necesita un nombre")]

        [MaxLength(11)]
        public string cTelefono { get; set; }

        [MaxLength(50)]
        public string cEmail { get; set; }

        public DateTime cCreado { get; set; }


    }
}

