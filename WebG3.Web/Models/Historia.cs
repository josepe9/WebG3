using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebG3.Web.Models
{
    public class Historia
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        public int AnimalId { get; set; }

        public int EnfermedadId { get; set; }

        [StringLength(45)]
        public string Detalle { get; set; }

        public int MedicoId { get; set; }

        public Enfermedad Enfermedad { get; set; }

        public Medico Medico { get; set; }

        public Animal Animal { get; set; }
    }
}
