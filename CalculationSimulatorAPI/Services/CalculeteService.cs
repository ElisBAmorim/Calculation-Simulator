using CalculationSimulatorAPI.Application.Dtos;
using CalculationSimulatorAPI.Dominio.Facade;
using CalculationSimulatorAPI.Dominio.Interfaces;
using CalculationSimulatorAPI.Dominio.Model;

namespace CalculationSimulatorAPI.Services
{
    public class CalculeteService : ICalculeteService
    {
        private readonly ILogger _logger;
        public CalculeteService(ILoggerFactory logger)
        {
            _logger = logger.CreateLogger<CalculeteService>();
        }

        public Task<CalculateResponseDto> CalculeteCDB(CalculateResquestDto request, CancellationToken cancellation)
        {
            _logger.LogInformation("Initialization of the service for the calculation of the CDB");

            FacadeCalculation facadeCBD = new(_logger, request.NumberOfMonths, request.ApplicationValue);
            FacadeCalculationModel resultCdb =  facadeCBD.CalculateValuesCDB();          
                              
            return Task.FromResult(new CalculateResponseDto(resultCdb.ResultGross, resultCdb.ResultNet));
        }
    }
}
