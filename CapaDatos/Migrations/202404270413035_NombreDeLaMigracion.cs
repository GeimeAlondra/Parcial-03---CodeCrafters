namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NombreDeLaMigracion : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.DetallePedidoes");
            AddColumn("dbo.DetallePedidoes", "DetallePedidoId", c => c.Int(nullable: false, identity: false));
            AddPrimaryKey("dbo.DetallePedidoes", "DetallePedidoId");
            DropColumn("dbo.DetallePedidoes", "DetalleVentaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DetallePedidoes", "DetalleVentaId", c => c.Int(nullable: false, identity: false));
            DropPrimaryKey("dbo.DetallePedidoes");
            DropColumn("dbo.DetallePedidoes", "DetallePedidoId");
            AddPrimaryKey("dbo.DetallePedidoes", "DetalleVentaId");
        }
    }
}
