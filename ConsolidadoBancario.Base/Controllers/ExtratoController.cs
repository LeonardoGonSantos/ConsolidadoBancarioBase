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
    public class ExtratoController : ControllerBase
    {

        private readonly ILogger<ExtratoController> _logger;

        public ExtratoController(ILogger<ExtratoController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public OkResult Extrato()
        {
            return Ok();
        }
    }
}
