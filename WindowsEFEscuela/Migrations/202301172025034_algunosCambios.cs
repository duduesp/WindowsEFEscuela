namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class algunosCambios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aulas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacidad = c.Int(nullable: false),
                        Codigo = c.String(nullable: false, maxLength: 1, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Programa = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Alumno", "ProfesorId", c => c.Int(nullable: false));
            AddColumn("dbo.Profesor", "Titulo", c => c.String(nullable: false, maxLength: 50, unicode: false));
            CreateIndex("dbo.Alumno", "ProfesorId");
            AddForeignKey("dbo.Alumno", "ProfesorId", "dbo.Profesor", "ProfesorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "ProfesorId", "dbo.Profesor");
            DropIndex("dbo.Alumno", new[] { "ProfesorId" });
            DropColumn("dbo.Profesor", "Titulo");
            DropColumn("dbo.Alumno", "ProfesorId");
            DropTable("dbo.Materias");
            DropTable("dbo.Aulas");
        }
    }
}
