using CalculationSimulatorAPI.Aplication.Controllers.V1;
using CalculationSimulatorAPI.Application.Dtos;
using CalculationSimulatorAPI.Dominio.Calculation;
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

            ICalculeCDB calculadoraCDB = new CalculeCDB(calculateResquest.ApplicationValue);


            return calculadoraCDB.ValueCalculationCDB().ToString();
        }
    }
}
