

namespace Capa_Logica
{
    public class MarcasLOG
    {
        MarcasDAL _MarcaDAL;

        public int GuardarMarca(Marca marca, int id = 0, bool esActualizacion = false)
        {
            _MarcaDAL = new MarcasDAL();

            return _MarcaDAL.Guardar(marca, id, esActualizacion);
        }

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
