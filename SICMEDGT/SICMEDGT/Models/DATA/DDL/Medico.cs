using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICMEDGT.Models.DATA.DDL
{
    public class Medico
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string Nombres { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string Apellidos { get; set; }

        //a uno

        [ForeignKey("Especialidad")]
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }

        [ForeignKey("Horario")]
        public int HorarioId { get; set; }
        public Horario Horario { get; set; }
    }
}
