using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICMEDGT.Models
{
    using System.Data.Entity;
    namespace Vidly.Models
    {
        public class MyDBContext : DbContext
        {
            public MyDBContext()
            {

             
        }
            public DbSet<SICMEDGT.Models.DATA.DDL.AntecedenteClinico> AntecedenteClinicos { get; set; }

            public DbSet<SICMEDGT.Models.DATA.DDL.Citas> Citas { get; set; }

            public DbSet<SICMEDGT.Models.DATA.DDL.Especialidad> Especialidads { get; set; }

            public DbSet<SICMEDGT.Models.DATA.DDL.ExamenClinico> ExamenClinicos { get; set; }

            public DbSet<SICMEDGT.Models.DATA.DDL.Horario> Horarios { get; set; }

            public DbSet<SICMEDGT.Models.DATA.DDL.Medicamento> Medicamentos { get; set; }

            public DbSet<SICMEDGT.Models.DATA.DDL.Medico> Medicos { get; set; }

            public DbSet<SICMEDGT.Models.DATA.DDL.Paciente> Pacientes { get; set; }

            public DbSet<SICMEDGT.Models.DATA.DDL.Receta> Recetas { get; set; }

        }
    }
}
