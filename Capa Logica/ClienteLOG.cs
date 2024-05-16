using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
        {
    public class ClienteLOG
    {
        ClienteDAL _ClienteDAL;

        public int GuardarCliente(Cliente cliente, int id = 0, bool esActualizacion = false)
        {
            _ClienteDAL = new ClienteDAL();

            return _ClienteDAL.Guardar(cliente, id, esActualizacion);
        }


        public int ActualizarCliente(Cliente cliente, int id = 0, bool esActualizacion = true)
        {
            _ClienteDAL = new ClienteDAL();

            return _ClienteDAL.Guardar(cliente, id, esActualizacion);
        }

        public int EliminarCliente(int Id)
        {
            _ClienteDAL = new ClienteDAL();

            return _ClienteDAL.Eliminar(Id);
        }


        public List<Cliente> ObtenerCliente(bool inactivos = false)
        {
            _ClienteDAL = new ClienteDAL();

            return _ClienteDAL.Leer(inactivos);
        }

        public Cliente ObtenerPorId(int id)
        {
            _ClienteDAL = new ClienteDAL();

            return _ClienteDAL.LeerPorId(id);
        }

        public List<Cliente> FiltroNombre(string nombre, bool inactivos = false)
        {
            _ClienteDAL = new ClienteDAL();

            return _ClienteDAL.FiltroNombre(nombre, inactivos);
        }
    }
}
