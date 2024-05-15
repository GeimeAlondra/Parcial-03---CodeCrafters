

namespace CapaDatos
{
    public class EmpleadoDAL
    {
        Contexto _db;

        // Guardar y editar Empleado
        public int Guardar(Empleado empleado, int id = 0, bool esActualizacion = false)
        {
            _db = new Contexto();

            int resultado;

            if (esActualizacion)
            {
                empleado.EmpleadoId = id;

                _db.Entry(empleado).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = empleado.EmpleadoId;
            }
            else
            {
                _db.Empleados.Add(empleado);
                _db.SaveChanges();

                resultado = empleado.EmpleadoId;
            }

            return resultado;
        }

        // Ver Empleado
        public List<Empleado> Leer(bool inactivos = false)
        {
            _db = new Contexto();
            if (inactivos)
            {
                return _db.Empleados
                    .Include(e => e.TipoEmpleado)
                    .Where(e => e.Estado == false ).ToList();
            }
            else
            {
                return _db.Empleados
                    .Include(e => e.TipoEmpleado)
                    .Where(e => e.Estado == true).ToList();
            }
        }

      

        // Eliminar Empleado
        public int Eliminar(int Id)
        {
            _db = new Contexto();
            int resultado = 0;
            var empleado = _db.Empleados.Find(Id);
            if (empleado != null)
            {
                empleado.Estado = false;
                _db.SaveChanges();
                resultado = empleado.EmpleadoId;
            }

            return resultado;

        }

        public Empleado LeerPorId(int id)
        {
            _db = new Contexto();

            return _db.Empleados.Find(id);
        }

        //Para llenar los combobox
        public List<TipoEmpleado> ObtenerTipoEmpleados()
        {
            _db = new Contexto();

            return _db.TipoEmpleados.ToList();
        }

        public List<Empleado> FiltroTipoEmpleados(int id, bool inactivos)
        {
            _db = new Contexto();
            if (inactivos)
            {
                return _db.Empleados
                   //.Include(e => e.TipoEmpleado)
                   .Where(e => e.TipoEmpleadoId == id && e.Estado == false).ToList();
            }
            else
            {
                return _db.Empleados
                    //.Include(e => e.TipoEmpleado)
                    .Where(e => e.TipoEmpleadoId == id && e.Estado == true).ToList();
            }

        }

        public List<Empleado> FiltroNombre(string nombre, bool inactivos)
        {
            _db = new Contexto();
            if (inactivos)
            {
                return _db.Empleados
                    //.Include(e => e.TipoEmpleado)
                    .Where(e => e.EmpleadoNombre.Contains(nombre) && e.Estado == false).ToList();
            }
            else
            {
                return _db.Empleados
                   //.Include(e => e.TipoEmpleado)
                    .Where(e => e.EmpleadoNombre.Contains(nombre) && e.Estado == true).ToList();
            }

        }
    }
}
