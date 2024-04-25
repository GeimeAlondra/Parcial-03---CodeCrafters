namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductoEstado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "Estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "Estado");
        }
    }
}
