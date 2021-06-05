using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SICMEDGT.Models.DATA.DDL
{
    public class AntecedenteClinico
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string Detalles { get; set; }

        public ICollection<Citas> Citas { get; set; }

        public ICollection<ExamenClinico> ExamenClinicos { get; set; }

    }
}
