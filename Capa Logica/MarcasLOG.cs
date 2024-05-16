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

        

        public int EliminarMarca(int Id)
        {
            _MarcaDAL = new MarcasDAL();

            return _MarcaDAL.Eliminar(Id);
        }


        public List<Marca> ObtenerMarcas()
        {
            _MarcaDAL = new MarcasDAL();

            return _MarcaDAL.Leer();
        }
    }
}
