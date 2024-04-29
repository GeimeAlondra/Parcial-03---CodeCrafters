using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class ProductoLOG
    {
        ProductoDAL _ProductoDAL;

        public int GuardarProducto(Producto producto, int id = 0, bool esActualizacion = false)
        {
            _ProductoDAL = new ProductoDAL();

            return _ProductoDAL.Guardar(producto, id, esActualizacion);
        }

        public Producto ObtenerProductoPorId(int codigo)
        {
            _ProductoDAL = new ProductoDAL();

            return _ProductoDAL.LeerPorId(codigo);
        }

        public List<Producto> ObtenerProductos()
        {
            _ProductoDAL = new ProductoDAL();

            return _ProductoDAL.Leer();
        }
    }
}
