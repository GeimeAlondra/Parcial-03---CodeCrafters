namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificacion_Fecha : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleadoes", "EmpleadoFechaNacimiento", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleadoes", "EmpleadoFechaNacimiento", c => c.DateTime(nullable: false));
        }
    }
}
