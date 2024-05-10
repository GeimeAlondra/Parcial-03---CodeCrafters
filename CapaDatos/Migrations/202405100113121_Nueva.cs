namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Nueva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        CategoriaNombre = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        ClienteNombre = c.String(nullable: false, maxLength: 80),
                        ClienteApellido = c.String(nullable: false, maxLength: 80),
                        ClienteDireccion = c.String(nullable: false, maxLength: 100),
                        ClienteCorreo = c.String(nullable: false, maxLength: 150),
                        ClienteTelefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.DetalleVentas",
                c => new
                    {
                        DetalleVentaId = c.Int(nullable: false, identity: true),
                        Cantidad = c.Int(nullable: false),
                        VentaId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetalleVentaId)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        ProductoNombre = c.String(nullable: false, maxLength: 80),
                        ProductoDescripcion = c.String(nullable: false, maxLength: 100),
                        ProductoPrecio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductoStock = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                        MarcaId = c.Int(nullable: false),
                        ProveedorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: true)
                .ForeignKey("dbo.Proveedors", t => t.ProveedorId, cascadeDelete: true)
                .Index(t => t.CategoriaId)
                .Index(t => t.MarcaId)
                .Index(t => t.ProveedorId);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        MarcaId = c.Int(nullable: false, identity: true),
                        MarcaNombre = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.MarcaId);
            
            CreateTable(
                "dbo.Proveedors",
                c => new
                    {
                        ProveedorId = c.Int(nullable: false, identity: true),
                        ProveedorNombre = c.String(nullable: false, maxLength: 80),
                        ProveedorCorreo = c.String(nullable: false, maxLength: 80),
                        ProveedorDireccion = c.String(nullable: false, maxLength: 100),
                        ProveedorTelefono = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProveedorId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        VentaFecha = c.String(nullable: false),
                        VentaTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClienteId = c.Int(nullable: false),
                        EmpleadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Empleadoes", t => t.EmpleadoId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpleadoId = c.Int(nullable: false, identity: true),
                        EmpleadoNombre = c.String(nullable: false, maxLength: 75),
                        EmpleadoApellido = c.String(nullable: false, maxLength: 75),
                        EmpleadoDireccion = c.String(nullable: false, maxLength: 100),
                        EmpleadoSalario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EmpleadoFechaNacimiento = c.String(nullable: false),
                        TipoEmpleadoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmpleadoId)
                .ForeignKey("dbo.TipoEmpleadoes", t => t.TipoEmpleadoId, cascadeDelete: true)
                .Index(t => t.TipoEmpleadoId);
            
            CreateTable(
                "dbo.TipoEmpleadoes",
                c => new
                    {
                        TipoEmpleadoId = c.Int(nullable: false, identity: true),
                        Cargo = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TipoEmpleadoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "EmpleadoId", "dbo.Empleadoes");
            DropForeignKey("dbo.Empleadoes", "TipoEmpleadoId", "dbo.TipoEmpleadoes");
            DropForeignKey("dbo.DetalleVentas", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.DetalleVentas", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.Productoes", "ProveedorId", "dbo.Proveedors");
            DropForeignKey("dbo.Productoes", "MarcaId", "dbo.Marcas");
            DropForeignKey("dbo.Productoes", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Empleadoes", new[] { "TipoEmpleadoId" });
            DropIndex("dbo.Ventas", new[] { "EmpleadoId" });
            DropIndex("dbo.Ventas", new[] { "ClienteId" });
            DropIndex("dbo.Productoes", new[] { "ProveedorId" });
            DropIndex("dbo.Productoes", new[] { "MarcaId" });
            DropIndex("dbo.Productoes", new[] { "CategoriaId" });
            DropIndex("dbo.DetalleVentas", new[] { "ProductoId" });
            DropIndex("dbo.DetalleVentas", new[] { "VentaId" });
            DropTable("dbo.TipoEmpleadoes");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Ventas");
            DropTable("dbo.Proveedors");
            DropTable("dbo.Marcas");
            DropTable("dbo.Productoes");
            DropTable("dbo.DetalleVentas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}
