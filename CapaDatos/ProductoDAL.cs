using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDAL
    {
        Contexto _db;
        public int Eliminar(int id)
        {

            _db = new Contexto();
            int resultado = 0;
            var producto = _db.Productos.Find(id);
            if (producto != null)
            {
                producto.Estado = false;
                _db.SaveChanges();
                resultado = producto.ProductoId;
            }

            return resultado;
        }



        // Guardar y actualizar Producto
        public int Guardar(Producto producto, int id = 0, bool esActualizacion = false)
        {
            _db = new Contexto();

            int resultado;

            if (esActualizacion)
            {
                producto.ProductoId = id;

                _db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = producto.ProductoId;
            }
            else
            {
                _db.Productos.Add(producto);
                _db.SaveChanges();

                resultado = producto.ProductoId;
            }

            return resultado;
        }

        // Ver Productos por Estado
        public List<Producto> Leer(bool inactivos = false)
        {
            _db = new Contexto();
            if (inactivos)
            {
                return _db.Productos
                    .Include(p => p.Categoria) 
                    .Include(p => p.Marca)
                    .Include(p => p.Proveedor)
                    .Where(p => p.Estado == false).ToList();
            }
            else
            {
                return _db.Productos
                    .Include(p => p.Categoria)
                    .Include(p => p.Marca)
                    .Include(p => p.Proveedor)
                    .Where(p => p.Estado == true).ToList();
            }
        }

        // Buscar Productos por ID
        public Producto LeerPorId(int id)
        {
            _db = new Contexto();

            return _db.Productos.Find(id);
        }

        //Para llenar los combobox
        public List<Marca> ObtenerMarcas()
        {
            _db = new Contexto();

            return _db.Marcas.ToList();
        }

        public List<Categoria> ObtenerCategorias()
        {
            _db = new Contexto();

            return _db.Categorias.ToList();
        }

        public List<Proveedor> ObtenerProveedores()
        {
            _db = new Contexto();

            return _db.Proveedores.ToList();
        }

        public List<Producto> FiltroCategorias(int id ,bool inactivos)
        {
            _db = new Contexto();
            if (inactivos) {
                return _db.Productos
                    .Include(p => p.Categoria)
                    .Include(p => p.Marca)
                    .Include(p => p.Proveedor)
                    .Where(p => p.CategoriaId == id && p.Estado == false ).ToList();
            }
            else
            {
                return _db.Productos
                    .Include(p => p.Categoria)
                    .Include(p => p.Marca)
                    .Include(p => p.Proveedor)
                    .Where(p => p.CategoriaId == id &&p.Estado == true).ToList();
            }

        }

        public List<Producto> FiltroMarca(int id, bool inactivos)
        {
            _db = new Contexto();
            if (inactivos)
            {
                return _db.Productos
                    .Include(p => p.Categoria)
                    .Include(p => p.Marca)
                    .Include(p => p.Proveedor)
                    .Where(p => p.MarcaId == id && p.Estado == false).ToList();
            }
            else
            {
                return _db.Productos
                    .Include(p => p.Categoria)
                    .Include(p => p.Marca)
                    .Include(p => p.Proveedor)
                    .Where(p => p.MarcaId == id && p.Estado == true).ToList();
            }

        }

        public List<Producto> FiltroProveedor(int id, bool inactivos)
        {
            _db = new Contexto();
            if (inactivos)
            {
                return _db.Productos
                    .Include(p => p.Categoria)
                    .Include(p => p.Marca)
                    .Include(p => p.Proveedor)
                    .Where(p => p.ProveedorId == id && p.Estado == false).ToList();
            }
            else
            {
                return _db.Productos
                    .Include(p => p.Categoria)
                    .Include(p => p.Marca)
                    .Include(p => p.Proveedor)
                    .Where(p => p.ProveedorId == id && p.Estado == true).ToList();
            }

        }

        public List<Producto> FiltroNombre(string nombre, bool inactivos)
        {
            _db = new Contexto();
            if (inactivos)
            {
                return _db.Productos
                    .Include(p => p.Categoria)
                    .Include(p => p.Marca)
                    .Include(p => p.Proveedor)
                    .Where(p => p.ProductoNombre.Contains(nombre) && p.Estado == false).ToList();
            }
            else
            {
                return _db.Productos
                    .Include(p => p.Categoria)
                    .Include(p => p.Marca)
                    .Include(p => p.Proveedor)
                    .Where(p => p.ProductoNombre.Contains(nombre) && p.Estado == true).ToList();
            } 



        }

        public int DescontarProductos(int id = 0, int cantidad = 0)
        {
            _db = new Contexto();
            // Buscar el producto por su ID
            var producto = _db.Productos.FirstOrDefault(p => p.ProductoId == id);

            if (producto != null)
            {
                // Descontar la cantidad del stock
                producto.ProductoStock = producto.ProductoStock - cantidad;

                // Asegurarse de que la cantidad no sea negativa
                if (producto.ProductoStock < 0)
                {
                    producto.ProductoStock = 0;
                }

                // Marcar el producto como modificado
                _db.Entry(producto).State = System.Data.Entity.EntityState.Modified;

                // Guardar los cambios
                return _db.SaveChanges();
            }
            else
            {
                // Manejar el caso donde no se encuentra el producto
                throw new Exception("Producto no encontrado");
            }
        }

    }
}
