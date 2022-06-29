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
    public class SaqueController : ControllerBase
    {

        private readonly ILogger<SaqueController> _logger;

        public SaqueController(ILogger<SaqueController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public OkResult Saque()
        {
            return Ok();
        }
    }
}
