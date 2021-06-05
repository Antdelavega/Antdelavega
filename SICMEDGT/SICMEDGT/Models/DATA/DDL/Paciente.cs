using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICMEDGT.Models.DATA.DDL
{
    public class Paciente
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string Nombres { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string Apellidos { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string DPI { get; set; }

        [MaxLength(10, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string TELEFONO { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string DIRECCION { get; set; }

        public ICollection<AntecedenteClinico> AntecedenteClinicos { get; set; }

        [ForeignKey("Citas")]
        public int CitasId { get; set; }
        public Citas Citas { get; set; }

       /* [ForeignKey("ExamenClinico")]
        public int ExamenClinicoId { get; set; }
        public ExamenClinico ExamenClinico { get; set; }

        */
    }
}
