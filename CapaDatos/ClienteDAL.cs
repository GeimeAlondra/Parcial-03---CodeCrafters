using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ClienteDAL
    {
        Contexto _db;

        // Guardar y actualizar Cliente
        public int Guardar(Cliente cliente, int id = 0, bool esActualizacion = false)
        {
            _db = new Contexto();

            int resultado;

            if (esActualizacion)
            {
                cliente.ClienteId = id;

                _db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = cliente.ClienteId;
            }
            else
            {
                _db.Clientes.Add(cliente);
                _db.SaveChanges();

                resultado = cliente.ClienteId;
            }

            return resultado;
        }

        // Ver Cliente
        public List<Cliente> Leer(bool inactivos = false)
        {
            _db = new Contexto();
            if (inactivos)
            {
                return _db.Clientes.Where(p => p.Estado == false).ToList();
            }
            else
            {
                return _db.Clientes.Where(p => p.Estado == true).ToList();
            }
        }

        // Eliminar Cliente
        public int Eliminar(int Id)
        {
            _db = new Contexto();
            int resultado = 0;

            var cliente = _db.Clientes.Find(Id);
            if (cliente != null)
            {
                cliente.Estado = false;
                _db.SaveChanges();
                resultado = cliente.ClienteId;
            }
           
            return resultado;

        }

        public Cliente LeerPorId(int id)
        {
            _db = new Contexto();

            return _db.Clientes.Find(id);
        }

        public List<Cliente> FiltroNombre(string nombre, bool inactivos)
        {
            _db = new Contexto();
            if (inactivos)
            {
                return _db.Clientes.Where(c => c.ClienteNombre.Contains(nombre) && c.Estado == false).ToList();
            }
            else
            {
                return _db.Clientes.Where(c => c.ClienteNombre.Contains(nombre) && c.Estado == true).ToList();
            }
        }
    }
}
