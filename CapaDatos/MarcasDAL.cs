using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MarcasDAL
    {
        Contexto _db;
        public int Guardar(Marca marca, int id = 0, bool esActualizacion = false)
        {
            _db = new Contexto();

            int resultado;

            if (esActualizacion)
            {
                marca.MarcaId = id;

                _db.Entry(marca).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = marca.MarcaId;
            }
            else
            {
                _db.Marcas.Add(marca);
                _db.SaveChanges();

                resultado = marca.MarcaId;
            }

            return resultado;
        }

        public List<Marca> Leer()
        {
            _db = new Contexto();

            return _db.Marcas.ToList();
        }


    }
}
