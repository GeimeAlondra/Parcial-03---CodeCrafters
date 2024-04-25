using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class TipoEmpleadoDAL
    {
        Contexto _db;

        // Guardar y actualizar TipoEmpleado
        public int Guardar(TipoEmpleado tipoEmpleado, int id = 0, bool esActualizacion = false)
        {
            _db = new Contexto();

            int resultado;

            if (esActualizacion)
            {
                tipoEmpleado.TipoEmpleadoId = id;

                _db.Entry(tipoEmpleado).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = tipoEmpleado.TipoEmpleadoId;
            }
            else
            {
                _db.TipoEmpleados.Add(tipoEmpleado);
                _db.SaveChanges();

                resultado = tipoEmpleado.TipoEmpleadoId;
            }

            return resultado;
        }

        // Ver TipoEmpleado
        public List<TipoEmpleado> Leer()
        {
            _db = new Contexto();

            return _db.TipoEmpleados.ToList();
        }

        // Eliminar TipoEmpleado
        public int Eliminar(int Id)
        {
            _db = new Contexto();
            int resultado;

            var tipoEmpleado = _db.TipoEmpleados.Find(Id);
            if (tipoEmpleado != null)
            {
                _db.TipoEmpleados.Remove(tipoEmpleado);
                _db.SaveChanges();
            }
            resultado = tipoEmpleado.TipoEmpleadoId;
            return resultado;

        }

    }
}
