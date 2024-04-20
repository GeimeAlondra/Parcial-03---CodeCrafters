using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class MarcasLOG
    {
        MarcasDAL _MarcaDAL;

        public int GuardarProducto(Marca marca, int id = 0, bool esActualizacion = false)
        {
            _MarcaDAL = new MarcasDAL();

            return _MarcaDAL.Guardar(marca, id, esActualizacion);
        }


    }
}
