using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class SucursalLOG
    {
        SucursalDAL _SucursalDAL;

        public int GuardarSucursal(Sucursal sucursal, int id = 0, bool esActualizacion = false)
        {
            _SucursalDAL = new SucursalDAL();

            return _SucursalDAL.Guardar(sucursal, id, esActualizacion);
        }

        public int EliminarSucursal(int Id)
        {
            _SucursalDAL = new SucursalDAL();

            return _SucursalDAL.Eliminar(Id);
        }


        public List<Sucursal> ObtenerSucursales()
        {
            _SucursalDAL = new SucursalDAL();

            return _SucursalDAL.Leer();
        }
    }
}
