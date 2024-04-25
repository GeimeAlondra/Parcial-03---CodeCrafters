using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class VentaDAL
    {
        Contexto _db;

        public int Guardar(Venta venta, int id = 0, bool esActualizacion = false)
        {
            _db = new Contexto();
            int resultado;

            if (esActualizacion)
            {
                venta.VentaId = id;

                _db.Entry(venta).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.Ventas.Add(venta);
                _db.SaveChanges();
            }

            resultado = venta.VentaId;

            return resultado;
        }

        //public List<Venta> LeerVenta()
        //{
        //    _db = new Contexto();
        //    return Contexto.Venta.Where(v => v.idVenta > 0).ToList();
        //}
    }
}
