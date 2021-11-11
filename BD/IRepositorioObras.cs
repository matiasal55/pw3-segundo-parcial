using System.Collections.Generic;
using BD.Modelos;

namespace BD
{
    public interface IRepositorioObras
    {
        void CrearObraDeArte(ObraDeArte obra);
        List<ObraDeArte> ObtenerObrasDelSigloXIX();
        ObraDeArte BuscarObraPorId(int id);
    }
}