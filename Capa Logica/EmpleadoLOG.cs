using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class EmpleadoLOG
    {
        EmpleadoDAL _EmpleadoDAL;

        public int GuardarEmpleado(Empleado empleado, int id = 0, bool esActualizacion = false)
        {
            _EmpleadoDAL = new EmpleadoDAL();

            return _EmpleadoDAL.Guardar(empleado, id, esActualizacion);
        }

        public int ActualizarEmpleado(Empleado empleado, int id = 0, bool esActualizacion = true)
        {
            _EmpleadoDAL = new EmpleadoDAL();

            return _EmpleadoDAL.Guardar(empleado, id, esActualizacion);
        }

        public int EliminarEmpleado(int Id)
        {
            _EmpleadoDAL = new EmpleadoDAL();

            return _EmpleadoDAL.Eliminar(Id);
        }

        public List<Empleado> ObtenerEmpleado()
        {
            _EmpleadoDAL = new EmpleadoDAL();

            return _EmpleadoDAL.Leer();
        }

        public Empleado ObtenerPorId(int id)
        {
            _EmpleadoDAL = new EmpleadoDAL();

            return _EmpleadoDAL.LeerPorId(id);
        }
    }
}
