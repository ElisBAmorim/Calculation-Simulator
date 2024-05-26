using CalculationSimulatorAPI.Aplication.Controllers.V1;
using CalculationSimulatorAPI.Application.Dtos;
using CalculationSimulatorAPI.Dominio.Calculation.CDB;
using CalculationSimulatorAPI.Dominio.Calculation.IR;
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
            _logger.LogInformation("Initialization of the service for the calculation of the CDB");

            Facade facadeCBD = new(request.NumberOfMonths, new CalculeCDB(request.ApplicationValue), new CalculeIR(request.ApplicationValue));
            facadeCBD.CalculateValuesCDB();
          
            
            return Task.FromResult(new CalculateResponseDto(facadeCBD.ResultGross, facadeCBD.ResultNet));
        }
    }
}
