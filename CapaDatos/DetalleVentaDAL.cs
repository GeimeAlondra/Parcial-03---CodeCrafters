using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DetalleVentaDAL
    {
        Contexto _db;

        // Guardar y actualizar Detalle de Venta
        public int GuardarDetalleVenta(DetalleVenta detalleVenta, int id, bool esActualizacion = false)
        {
            _db = new Contexto();
            int resultado;

            if (esActualizacion)
            {
                detalleVenta.DetalleVentaId = id;

                _db.Entry(detalleVenta).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.DetalleVentas.Add(detalleVenta);
                _db.SaveChanges();
            }

            resultado = detalleVenta.DetalleVentaId;
            return resultado;
        }

        // Leer Detalle de Venta
        public List<DetalleVenta> LeerDetalleVenta()
        {
            _db = new Contexto();
            return _db.DetalleVentas.Where(v => v.DetalleVentaId > 0).ToList();
        }
    }
}
