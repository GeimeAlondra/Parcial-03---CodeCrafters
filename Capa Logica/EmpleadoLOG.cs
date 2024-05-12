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

        public List<Empleado> ObtenerEmpleado(bool inactivos = false)
        {
            _EmpleadoDAL = new EmpleadoDAL();

            return _EmpleadoDAL.Leer(inactivos);
        }

        public Empleado ObtenerPorId(int id)
        {
            _EmpleadoDAL = new EmpleadoDAL();

            return _EmpleadoDAL.LeerPorId(id);
        }

        // Combo box
        public List<TipoEmpleado> ObtenerTipoEmpleado()
        {
            _EmpleadoDAL = new EmpleadoDAL();

            return _EmpleadoDAL.ObtenerTipoEmpleados();
        }

        public List<Empleado> FiltroTipoEmpleado(int categoriaValue, bool inactivos = false)
        {
            _EmpleadoDAL = new EmpleadoDAL();

            return _EmpleadoDAL.FiltroTipoEmpleados(categoriaValue, inactivos);
        }

        public List<Empleado> FiltroNombre(string nombre, bool inactivos = false)
        {
            _EmpleadoDAL = new EmpleadoDAL();

            return _EmpleadoDAL.FiltroNombre(nombre, inactivos);
        }
    }
}
