﻿using CapaDatos;
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

        public int EliminarCliente(int Id)
        {
            _ClienteDAL = new ClienteDAL();

            return _ClienteDAL.Eliminar(Id);
        }


        public List<Cliente> ObtenerCliente()
        {
            _ClienteDAL = new ClienteDAL();

            return _ClienteDAL.Leer();
        }
    }
}
