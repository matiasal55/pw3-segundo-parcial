using System.Collections.Generic;
using System.Linq;
using BD.ModeloEF;
using BD.Modelos;

namespace BD
{
    public class RepositorioObras : IRepositorioObras
    {
        private Context _context;

        public RepositorioObras(Context context)
        {
            _context = context;
        }

        public void CrearObraDeArte(ObraDeArte obra)
        {
            _context.ObraDeArtes.Add(obra);
            _context.SaveChanges();
        }

        public List<ObraDeArte> ObtenerObrasDelSigloXIX()
        {
            return _context.ObraDeArtes.Where(obra => obra.AnioCreacion >= 1800 && obra.AnioCreacion <= 1899).OrderByDescending(obra => obra.AnioCreacion).ToList();
        }

        public ObraDeArte BuscarObraPorId(int id)
        {
            return _context.ObraDeArtes.FirstOrDefault(obra => obra.Id == id);
        }
    }
}