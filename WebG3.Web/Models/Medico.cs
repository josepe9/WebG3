using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebG3.Web.Models
{
    public class Medico
    {
        [Key]
        public int Id { get; set; }

        public int PersonaId { get; set; }

        [StringLength(45)]
        public string Detalle { get; set; }

        public ICollection<Historia> Historias { get; set; }

       // public Persona Persona { get; set; }
    }
}
