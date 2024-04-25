using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDAL
    {
        Contexto _db;

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
        public List<Producto> Leer()
        {
            _db = new Contexto();

            return _db.Productos.Where(p => p.Estado == true).ToList();
        }

        // Buscar Productos por ID
        public Producto LeerPorId(int id)
        {
            _db = new Contexto();

            return _db.Productos.Find(id);
        }
    }
}
