using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class ProveedorLOG
    {
        ProveedorDAL _ProveedorDAL;

        public int GuardarProveedor(Proveedor proveedor, int id = 0, bool esActualizacion = false)
        {
            _ProveedorDAL = new ProveedorDAL();

            return _ProveedorDAL.Guardar(proveedor, id, esActualizacion);
        }

        public int ActualizarProveedor(Proveedor proveedor, int id, bool esActualizacion)
        {
            _ProveedorDAL = new ProveedorDAL();

            return _ProveedorDAL.Guardar(proveedor, id, esActualizacion);
        }

        public int EliminarProveedor(int Id)
        {
            _ProveedorDAL = new ProveedorDAL();

            return _ProveedorDAL.Eliminar(Id);
        }

        public List<Proveedor> ObtenerProveedor(bool inactivos = false)
        {
            _ProveedorDAL = new ProveedorDAL();

            return _ProveedorDAL.Leer(inactivos);
        }

        public Proveedor ObtenerProveedorPorId(int codigo)
        {
            _ProveedorDAL = new ProveedorDAL();

            return _ProveedorDAL.LeerPorId(codigo);
        }

        public List<Proveedor> FiltroNombre(string nombre, bool inactivos = false)
        {
            _ProveedorDAL = new ProveedorDAL();

            return _ProveedorDAL.FiltroNombre(nombre, inactivos);
        }
    }
}
