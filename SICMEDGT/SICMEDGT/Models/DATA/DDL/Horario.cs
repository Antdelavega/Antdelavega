using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SICMEDGT.Models.DATA.DDL
{
    public class Horario
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "El campo {0} debe tener un maxiomo de 45 caracteres.")]
        public string Dia { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Hora_Ingreso { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Hora_Salida { get; set; }

        //muchos
        public ICollection<Medico> Medicos { get; set; }

    }
}
