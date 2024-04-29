using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class DetalleVentaLOG
    {
        DetalleVentaDAL _DetalleVentaDAL;

        public int GuardarDetalleVenta(DetalleVenta detalleVenta, int id = 0, bool esActualizacion = false)
        {
            _DetalleVentaDAL = new DetalleVentaDAL();

            return _DetalleVentaDAL.GuardarDetalleVenta(detalleVenta, id, esActualizacion);
        }

        public List<DetalleVenta> ObtenerDetalleVenta()
        {
            _DetalleVentaDAL = new DetalleVentaDAL();

            return _DetalleVentaDAL.LeerDetalleVenta();
        }
    }
}
