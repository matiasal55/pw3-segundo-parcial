using System.Collections.Generic;
using BD;
using BD.Modelos;

namespace Servicio
{
    public class ServicioObras : IServicioObras
    {
        private IRepositorioObras _repositorioObras;

        public ServicioObras(IRepositorioObras repositorioObras)
        {
            _repositorioObras = repositorioObras;
        }

        public void CrearObraDeArte(ObraDeArte obra)
        {
            _repositorioObras.CrearObraDeArte(obra);
        }

        public List<ObraDeArte> ObtenerObrasDelSigloXIX()
        {
            return _repositorioObras.ObtenerObrasDelSigloXIX();
        }

        public ObraDeArte BuscarObraPorId(int id)
        {
            return _repositorioObras.BuscarObraPorId(id);
        }
    }
}