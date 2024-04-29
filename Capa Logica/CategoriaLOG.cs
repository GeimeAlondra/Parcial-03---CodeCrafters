using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class CategoriaLOG
    {
        CategoriaDAL _CategoriaDAL;

        public int GuardarCategoria(Categoria categoria, int id = 0, bool esActualizacion = false)
        {
            _CategoriaDAL = new CategoriaDAL();

            return _CategoriaDAL.Guardar(categoria, id, esActualizacion);
        }

        public int ActualizarCategoria(Categoria categoria, int id = 0, bool esActualizacion = true)
        {
            _CategoriaDAL = new CategoriaDAL();

            return _CategoriaDAL.Guardar(categoria, id, esActualizacion);
        }





        public int EliminarCategoria(int Id)
        {
            _CategoriaDAL = new CategoriaDAL();

            return _CategoriaDAL.Eliminar(Id);
        }


        public List<Categoria> ObtenerCategorias()
        {
            _CategoriaDAL = new CategoriaDAL();

            return _CategoriaDAL.Leer();
        }

        public Categoria ObtenerPorId(int id)
        {
            _CategoriaDAL = new CategoriaDAL();
            return _CategoriaDAL.LeerPorId(id);
        }

    }
}
