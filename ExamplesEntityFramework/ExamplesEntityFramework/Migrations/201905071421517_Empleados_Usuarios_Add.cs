namespace ExamplesEntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Empleados_Usuarios_Add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleados",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dni = c.String(maxLength: 8),
                        Apellidos = c.String(),
                        Nombres = c.String(),
                        Cargo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Dni, unique: true);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Alias = c.String(),
                        Clave = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleados", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.Alias, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "Id", "dbo.Empleados");
            DropIndex("dbo.Usuarios", new[] { "Alias" });
            DropIndex("dbo.Usuarios", new[] { "Id" });
            DropIndex("dbo.Empleados", new[] { "Dni" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Empleados");
        }
    }
}
