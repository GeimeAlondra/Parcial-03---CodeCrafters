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

        // Eliminar Proveedor
        public int Eliminar(int Id)
        {
            _db = new Contexto();
            int resultado;

            var proveedor = _db.Proveedores.Find(Id);
            if (proveedor != null)
            {
                _db.Proveedores.Remove(proveedor);
                _db.SaveChanges();
            }
            resultado = proveedor.ProveedorId;
            return resultado;

        }


    }
}
