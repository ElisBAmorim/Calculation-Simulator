using CalculationSimulatorAPI.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculationSimulatorAPI.Aplication.Controllers.V1
{
    [ApiController]
    [Route("/v1/[controller]")]
    public class CalculateController : ControllerBase
    {
        private readonly ICalculeteService _calculateService;

        public CalculateController(ICalculeteService calculateService)
        {
            _calculateService = calculateService;
        }

        [HttpGet("/CDB")]
        [ProducesResponseType(typeof(string),StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTeste()
        {
            var result = await _calculateService.CalculeteCDB();
            return Ok(result);

        }

    }
}
