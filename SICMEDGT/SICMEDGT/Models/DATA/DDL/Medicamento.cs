using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SICMEDGT.Models.DATA.DDL
{
    public class Medicamento
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "El campo {0} debe tener un maximo de 50 caracteres.")]
        public string DesMedicamento { get; set; }

        public ICollection<Receta> Recetas { get; set; }
    }
}
