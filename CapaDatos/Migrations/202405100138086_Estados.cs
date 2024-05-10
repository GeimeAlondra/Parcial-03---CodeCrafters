namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Estados : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Proveedors", "Estado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Empleadoes", "Estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Empleadoes", "Estado");
            DropColumn("dbo.Proveedors", "Estado");
            DropColumn("dbo.Clientes", "Estado");
        }
    }
}
