using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsolidadoBancario.Base.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrasnferenciaController : ControllerBase
    {
        private readonly ILogger<TrasnferenciaController> _logger;

        public TrasnferenciaController(ILogger<TrasnferenciaController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public OkResult TransferirEntreContas()
        {
            return Ok();
        }
    }
}
