using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICMEDGT.Models.DATA.DDL
{
    public class ExamenClinico
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string Des_examen { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_examen { get; set; }


        [MaxLength(200, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string resultado_examen { get; set; }


        [ForeignKey("Medico")]
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }


        [ForeignKey("Paciente")]
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        [ForeignKey("Receta")]
        public int RecetaId { get; set; }
        public Receta Receta { get; set; }
    }
}
