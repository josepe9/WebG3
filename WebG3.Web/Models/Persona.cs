using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebG3.Web.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(45)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(45)]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [Display(Name = "Ciudad")]
        public int CiudadId { get; set; }

        [StringLength(45)]
        public string Email { get; set; }

        [StringLength(20)]
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        public Ciudad Ciudad { get; set; }

        public ICollection<Animal> Animales { get; set; }

       // public ICollection<Medico> Medicos { get; set; }
    }
}
