using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Empleado> Leer()
        {
            _db = new Contexto();

            return _db.Empleados.ToList();
        }

        // Eliminar Empleado
        public int Eliminar(int Id)
        {
            _db = new Contexto();
            int resultado;

            var empleado = _db.Empleados.Find(Id);
            if (empleado != null)
            {
                _db.Empleados.Remove(empleado);
                _db.SaveChanges();
            }
            resultado = empleado.EmpleadoId;
            return resultado;

        }

        public Empleado LeerPorId(int id)
        {
            _db = new Contexto();

            return _db.Empleados.Find(id);
        }
    }
}
