using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace WebG3.Web.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        public int RazaId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha nacimiento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fechan { get; set; }

        public int PersonaId { get; set; }

        public ICollection<Historia> Historias { get; set; }

        public Raza Raza { get; set; }

        public Persona Persona { get; set; }
    }
}
