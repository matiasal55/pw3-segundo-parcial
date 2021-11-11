using System.Collections.Generic;
using BD.Modelos;

namespace Servicio
{
    public interface IServicioObras
    {
        void CrearObraDeArte(ObraDeArte obra);
        List<ObraDeArte> ObtenerObrasDelSigloXIX();
        ObraDeArte BuscarObraPorId(int id);
    }
}