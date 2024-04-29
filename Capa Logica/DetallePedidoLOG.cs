using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class DetallePedidoLOG
    {
        DetallePedidoDAL _DetallePedidoDAL;

        public int GuardarDetallePedido(DetallePedido detallePedido, int id = 0, bool esActualizacion = false)
        {
            _DetallePedidoDAL = new DetallePedidoDAL();

            return _DetallePedidoDAL.GuardarDetallePedido(detallePedido, id, esActualizacion);
        }

        public List<DetallePedido> ObtenerDetallePedido()
        {
            _DetallePedidoDAL = new DetallePedidoDAL();

            return _DetallePedidoDAL.LeerDetallePedido();
        }
    }
}
