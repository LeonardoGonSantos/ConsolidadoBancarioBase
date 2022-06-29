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
    public class DepositoController : ControllerBase
    {

        private readonly ILogger<DepositoController> _logger;

        public DepositoController(ILogger<DepositoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public OkResult Depositar()
        {
            return Ok();
        }
    }
}
