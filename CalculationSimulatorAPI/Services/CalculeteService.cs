using CalculationSimulatorAPI.Application.Dtos;
using CalculationSimulatorAPI.Dominio.Calculation.CDB;
using CalculationSimulatorAPI.Dominio.Calculation.IR;
using CalculationSimulatorAPI.Dominio.Facade;
using CalculationSimulatorAPI.Dominio.Interfaces;

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

            Facade facadeCBD = new(request.NumberOfMonths, 
                new CalculeCDB(_logger, request.ApplicationValue), 
                new CalculeIR(_logger, request.ApplicationValue), 
                _logger);

            facadeCBD.CalculateValuesCDB();
          
            
            return Task.FromResult(new CalculateResponseDto(facadeCBD.ResultGross, facadeCBD.ResultNet));
        }
    }
}
