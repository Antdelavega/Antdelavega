using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICMEDGT.Models.DATA.DDL
{
    public class Receta
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime fecha_consulta { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string Cantidad { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string Des_Dosis { get; set; }

        [ForeignKey("Medicamento")]
        public int MedicamentoId { get; set; }
        public Medicamento Medicamento { get; set; }



    }
}
