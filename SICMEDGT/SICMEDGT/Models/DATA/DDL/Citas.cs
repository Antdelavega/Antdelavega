using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICMEDGT.Models.DATA.DDL
{
    public class Citas
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_Hora { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_preparado { get; set; }

       /* [ForeignKey("Paciente")]
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
       */


        [ForeignKey("Medico")]
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }

        public ICollection<Paciente> Pacientes { get; set; }
        public ICollection<AntecedenteClinico> AntecedenteClinicos { get; set; }
    }
}
