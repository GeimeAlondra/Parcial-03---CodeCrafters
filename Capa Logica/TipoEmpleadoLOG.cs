using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class TipoEmpleadoLOG
    {
        TipoEmpleadoDAL _TipoEmpleadoDAL;

        public int GuardarTipoEmpleado(TipoEmpleado tipoEmpleado, int id = 0, bool esActualizacion = false)
        {
            _TipoEmpleadoDAL = new TipoEmpleadoDAL();

            return _TipoEmpleadoDAL.Guardar(tipoEmpleado, id, esActualizacion);
        }

        public int EliminarTipoEmpleado(int Id)
        {
            _TipoEmpleadoDAL = new TipoEmpleadoDAL();

            return _TipoEmpleadoDAL.Eliminar(Id);
        }


        public List<TipoEmpleado> ObtenerTipoEmpleados()
        {
            _TipoEmpleadoDAL = new TipoEmpleadoDAL();

            return _TipoEmpleadoDAL.Leer();
        }
    }
}
