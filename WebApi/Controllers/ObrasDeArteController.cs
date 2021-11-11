using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicio;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObrasDeArteController : ControllerBase
    {
        private IServicioObras _servicioObras;

        public ObrasDeArteController(IServicioObras servicioObras)
        {
            _servicioObras = servicioObras;
        }

        // GET: api/ObrasDeArte/5
        [HttpGet("{id}", Name = "Get")]
        public ObraDeArte Get(int id)
        {
            return _servicioObras.BuscarObraPorId(id);
        }
    }
}
