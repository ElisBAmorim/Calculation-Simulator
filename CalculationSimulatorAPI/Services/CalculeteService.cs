using CalculationSimulatorAPI.Aplication.Controllers.V1;
using CalculationSimulatorAPI.Dominio.Interfaces;

namespace CalculationSimulatorAPI.Services
{
    public class CalculeteService : ICalculeteService
    {
        private readonly ILogger<CalculateController> _logger;
        public CalculeteService(ILogger<CalculateController> logger)
        {
            _logger = logger;
        }

        public async Task<string> CalculeteCDB()
        {
            await Task.Delay(1000);
            return "ok";
        }
    }
}
