using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace sistema_academico.Models
{
    public class Docente
    {
        [Key]
        public int idDocente { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public byte[] foto { get; set; }
    }
}
