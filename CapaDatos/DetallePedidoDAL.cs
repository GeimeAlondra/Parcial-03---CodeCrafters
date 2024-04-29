using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DetallePedidoDAL
    {
        Contexto _db;

        // Guardar y actualizar Detalle de Pedido
        public int GuardarDetallePedido(DetallePedido detallePedido, int id, bool esActualizacion = false)
        {
            _db = new Contexto();
            int resultado;

            if (esActualizacion)
            {
                detallePedido.DetallePedidoId = id;

                _db.Entry(detallePedido).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = detallePedido.DetallePedidoId;
            }
            else
            {
                _db.DetallePedidos.Add(detallePedido);
                _db.SaveChanges();

                resultado = detallePedido.DetallePedidoId;
            }

            return resultado;
        }

        // Leer Detalle de Pedido
        public List<DetallePedido> LeerDetallePedido()
        {
            _db = new Contexto();
            return _db.DetallePedidos.Where(v => v.DetallePedidoId > 0).ToList();
        }
    }
}
