using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SICMEDGT.Models.DATA.DDL
{
    public class Especialidad
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(45, ErrorMessage = "El campo {0} debe tener un maxiomo de 50 caracteres.")]
        public string Nombre { get; set; }

        public ICollection<Medico> Medicos { get; set; }


    }
}
