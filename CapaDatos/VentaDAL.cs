using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VentaDAL
    {
        Contexto _db;

        public List<Venta> FiltroCodigo(int id)
        {
            
            _db = new Contexto();
            return _db.Ventas
                .Include(v => v.Empleado)
                .Include(v => v.Cliente)
                .Where(v => v.VentaId.Equals(id)).ToList();
        }

        public List<Venta> FiltroNombres(string name)
        {

            _db = new Contexto();
            return _db.Ventas
                .Include(v => v.Empleado)
                .Include(v => v.Cliente)
                .Where(v => v.Cliente.ClienteNombre.Contains(name)).ToList();
        }




        // Guardar y actualizar Venta
        public int Guardar(Venta venta, int id = 0, bool esActualizacion = false)
        {
            _db = new Contexto();
            int resultado;

            if (esActualizacion)
            {
                venta.VentaId = id;

                _db.Entry(venta).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.Ventas.Add(venta);
                _db.SaveChanges();
            }

            resultado = venta.VentaId;

            return resultado;
        }

        // Ver Venta
        public List<Venta> ObtenerVentaPorId()
        {
            _db = new Contexto();
            return _db.Ventas.Where(v => v.VentaId > 0).ToList();
        }

        //Obtener todas las ventas
        public List<Venta> ObtenerVentas()
        {
            _db = new Contexto();
            return _db.Ventas
                .Include(v => v.Empleado)
                .Include(v => v.Cliente).ToList();

        }
    }
}
