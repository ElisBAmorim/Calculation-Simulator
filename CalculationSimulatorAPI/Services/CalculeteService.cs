using CalculationSimulatorAPI.Aplication.Controllers.V1;
using CalculationSimulatorAPI.Application.Dtos;
using CalculationSimulatorAPI.Dominio.Facade;
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

        public Task<CalculateResponseDto> CalculeteCDB(CalculateResquestDto request)
        {
            Facade facadeCBD = new(request.ApplicationValue,request.NumberOfMonths);
            facadeCBD.CalculateValueCDB();
          

            return Task.FromResult(new CalculateResponseDto(facadeCBD.resultGross, facadeCBD.resultNet));
        }
    }
}
