using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProveedorDAL
    {

        Contexto _db;

        // Guardar y actualizar Proveedor
        public int Guardar(Proveedor proveedor, int id = 0, bool esActualizacion = false)
        {
            _db = new Contexto();

            int resultado;

            if (esActualizacion)
            {
                proveedor.ProveedorId = id;

                _db.Entry(proveedor).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = proveedor.ProveedorId;
            }
            else
            {
                _db.Proveedores.Add(proveedor);
                _db.SaveChanges();

                resultado = proveedor.ProveedorId;
            }

            return resultado;
        }

        // Ver Proveedor
        public List<Proveedor> Leer()
        {
            _db = new Contexto();

            return _db.Proveedores.ToList();
        }

        // Ver Proveedores por Estado
        public List<Proveedor> Leer(bool inactivos = false)
        {
            _db = new Contexto();
            if (inactivos)
            {
                return _db.Proveedores.Where(p => p.Estado == false).ToList();
            }
            else
            {
                return _db.Proveedores.Where(p => p.Estado == true).ToList();
            }
        }

        // Buscar Proveedores por ID
        public Proveedor LeerPorId(int id)
        {
            _db = new Contexto();

            return _db.Proveedores.Find(id);
        }

        // Eliminar Proveedor
        public int Eliminar(int Id)
        {
            _db = new Contexto();
            int resultado = 0;
            var proveedor = _db.Proveedores.Find(Id);
            if (proveedor != null)
            {
                proveedor.Estado = true;
                _db.SaveChanges();
                resultado = proveedor.ProveedorId;
            }
            return resultado;
        }
    }
}
