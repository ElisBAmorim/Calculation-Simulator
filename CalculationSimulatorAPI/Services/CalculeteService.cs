using CalculationSimulatorAPI.Aplication.Controllers.V1;
using CalculationSimulatorAPI.Application.Dtos;
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

        public async Task<string> CalculeteCDB(CalculateResquestDto calculateResquest)
        {
            await Task.Delay(1000);
            return string.Format(calculateResquest.ApplicationValue.ToString() + calculateResquest.NumberOfMonths.ToString());
        }
    }
}
