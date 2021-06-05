namespace SICMEDGT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAll2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AntecedenteClinicoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Detalles = c.String(maxLength: 100),
                        Paciente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_Id)
                .Index(t => t.Paciente_Id);
            
            CreateTable(
                "dbo.Citas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        fecha_Hora = c.DateTime(nullable: false),
                        fecha_preparado = c.DateTime(nullable: false),
                        MedicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicos", t => t.MedicoId, cascadeDelete: true)
                .Index(t => t.MedicoId);
            
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        Apellidos = c.String(nullable: false, maxLength: 50),
                        EspecialidadId = c.Int(nullable: false),
                        HorarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Especialidads", t => t.EspecialidadId, cascadeDelete: true)
                .ForeignKey("dbo.Horarios", t => t.HorarioId, cascadeDelete: true)
                .Index(t => t.EspecialidadId)
                .Index(t => t.HorarioId);
            
            CreateTable(
                "dbo.Especialidads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 45),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Horarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dia = c.String(nullable: false, maxLength: 40),
                        Hora_Ingreso = c.DateTime(nullable: false),
                        Hora_Salida = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(maxLength: 50),
                        Apellidos = c.String(maxLength: 50),
                        DPI = c.String(maxLength: 50),
                        TELEFONO = c.String(maxLength: 10),
                        DIRECCION = c.String(nullable: false, maxLength: 100),
                        CitasId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Citas", t => t.CitasId, cascadeDelete: true)
                .Index(t => t.CitasId);
            
            CreateTable(
                "dbo.ExamenClinicoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Des_examen = c.String(nullable: false, maxLength: 50),
                        Fecha_examen = c.DateTime(nullable: false),
                        resultado_examen = c.String(maxLength: 200),
                        MedicoId = c.Int(nullable: false),
                        PacienteId = c.Int(nullable: false),
                        RecetaId = c.Int(nullable: false),
                        AntecedenteClinico_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicos", t => t.MedicoId, cascadeDelete: true)
                .ForeignKey("dbo.Pacientes", t => t.PacienteId, cascadeDelete: false)
                .ForeignKey("dbo.Recetas", t => t.RecetaId, cascadeDelete: true)
                .ForeignKey("dbo.AntecedenteClinicoes", t => t.AntecedenteClinico_Id)
                .Index(t => t.MedicoId)
                .Index(t => t.PacienteId)
                .Index(t => t.RecetaId)
                .Index(t => t.AntecedenteClinico_Id);
            
            CreateTable(
                "dbo.Recetas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        fecha_consulta = c.DateTime(nullable: false),
                        Cantidad = c.String(nullable: false, maxLength: 50),
                        Des_Dosis = c.String(maxLength: 50),
                        MedicamentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicamentoes", t => t.MedicamentoId, cascadeDelete: true)
                .Index(t => t.MedicamentoId);
            
            CreateTable(
                "dbo.Medicamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DesMedicamento = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CitasAntecedenteClinicoes",
                c => new
                    {
                        Citas_Id = c.Int(nullable: false),
                        AntecedenteClinico_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Citas_Id, t.AntecedenteClinico_Id })
                .ForeignKey("dbo.Citas", t => t.Citas_Id, cascadeDelete: true)
                .ForeignKey("dbo.AntecedenteClinicoes", t => t.AntecedenteClinico_Id, cascadeDelete: true)
                .Index(t => t.Citas_Id)
                .Index(t => t.AntecedenteClinico_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExamenClinicoes", "AntecedenteClinico_Id", "dbo.AntecedenteClinicoes");
            DropForeignKey("dbo.ExamenClinicoes", "RecetaId", "dbo.Recetas");
            DropForeignKey("dbo.Recetas", "MedicamentoId", "dbo.Medicamentoes");
            DropForeignKey("dbo.ExamenClinicoes", "PacienteId", "dbo.Pacientes");
            DropForeignKey("dbo.ExamenClinicoes", "MedicoId", "dbo.Medicos");
            DropForeignKey("dbo.Pacientes", "CitasId", "dbo.Citas");
            DropForeignKey("dbo.AntecedenteClinicoes", "Paciente_Id", "dbo.Pacientes");
            DropForeignKey("dbo.Citas", "MedicoId", "dbo.Medicos");
            DropForeignKey("dbo.Medicos", "HorarioId", "dbo.Horarios");
            DropForeignKey("dbo.Medicos", "EspecialidadId", "dbo.Especialidads");
            DropForeignKey("dbo.CitasAntecedenteClinicoes", "AntecedenteClinico_Id", "dbo.AntecedenteClinicoes");
            DropForeignKey("dbo.CitasAntecedenteClinicoes", "Citas_Id", "dbo.Citas");
            DropIndex("dbo.CitasAntecedenteClinicoes", new[] { "AntecedenteClinico_Id" });
            DropIndex("dbo.CitasAntecedenteClinicoes", new[] { "Citas_Id" });
            DropIndex("dbo.Recetas", new[] { "MedicamentoId" });
            DropIndex("dbo.ExamenClinicoes", new[] { "AntecedenteClinico_Id" });
            DropIndex("dbo.ExamenClinicoes", new[] { "RecetaId" });
            DropIndex("dbo.ExamenClinicoes", new[] { "PacienteId" });
            DropIndex("dbo.ExamenClinicoes", new[] { "MedicoId" });
            DropIndex("dbo.Pacientes", new[] { "CitasId" });
            DropIndex("dbo.Medicos", new[] { "HorarioId" });
            DropIndex("dbo.Medicos", new[] { "EspecialidadId" });
            DropIndex("dbo.Citas", new[] { "MedicoId" });
            DropIndex("dbo.AntecedenteClinicoes", new[] { "Paciente_Id" });
            DropTable("dbo.CitasAntecedenteClinicoes");
            DropTable("dbo.Medicamentoes");
            DropTable("dbo.Recetas");
            DropTable("dbo.ExamenClinicoes");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Horarios");
            DropTable("dbo.Especialidads");
            DropTable("dbo.Medicos");
            DropTable("dbo.Citas");
            DropTable("dbo.AntecedenteClinicoes");
        }
    }
}
