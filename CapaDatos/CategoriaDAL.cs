using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CategoriaDAL
    {
        Contexto _db;

        // Guardar y actualizar Categoria
       
         public int Guardar(Categoria categoria, int id = 0, bool esActualizacion = false)
        {
            _db = new Contexto();

            int resultado;

            if (esActualizacion)
            {
                categoria.CategoriaId = id;

                _db.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = categoria.CategoriaId;
            }
            else
            {
                _db.Categorias.Add(categoria);
                _db.SaveChanges();

                resultado = categoria.CategoriaId;
            }

            return resultado;
        }
        // Ver Categoria
        public List<Categoria> Leer()
        {
            _db = new Contexto();

            return _db.Categorias.ToList();
        }

        // Eliminar Categoria
        public int Eliminar(int Id)
        {
            _db = new Contexto();
            int resultado;

            var categoria = _db.Categorias.Find(Id);
            if (categoria != null)
            {
                _db.Categorias.Remove(categoria);
                _db.SaveChanges();
            }
            resultado = categoria.CategoriaId;
            return resultado;

        }


        //Obtner por Id
        public Categoria LeerPorId(int id)
        {
            _db = new Contexto();

            return _db.Categorias.Find(id);
        }
    }
}
