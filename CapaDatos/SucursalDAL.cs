using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class SucursalDAL
    {
        Contexto _db;

        // Guardar y actualizar Sucursal
        public int Guardar(Sucursal sucursal, int id = 0, bool esActualizacion = false)
        {
            _db = new Contexto();

            int resultado;

            if (esActualizacion)
            {
                sucursal.SucursalId = id;

                _db.Entry(sucursal).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = sucursal.SucursalId;
            }
            else
            {
                _db.Sucursales.Add(sucursal);
                _db.SaveChanges();

                resultado = sucursal.SucursalId;
            }

            return resultado;
        }

        // Ver Sucursal
        public List<Sucursal> Leer()
        {
            _db = new Contexto();

            return _db.Sucursales.ToList();
        }

        // Eliminar Sucursal
        public int Eliminar(int Id)
        {
            _db = new Contexto();
            int resultado;

            var sucursal = _db.Sucursales.Find(Id);
            if (sucursal != null)
            {
                _db.Sucursales.Remove(sucursal);
                _db.SaveChanges();
            }
            resultado = sucursal.SucursalId;
            return resultado;

        }
    }
}
