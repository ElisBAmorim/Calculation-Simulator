using CalculationSimulatorAPI.Application.Dtos;
using CalculationSimulatorAPI.Dominio.Interfaces;
using CalculationSimulatorAPI.Services;
using Microsoft.Extensions.Logging;

namespace CalculationSimulatorAPI.Tests.Services
{
    public class CalculeteServiceTest
    {
        private readonly ICalculeteService _calculatorService;     
        private readonly ILoggerFactory _logger;
      
        public CalculeteServiceTest()
        {
             _logger = new LoggerFactory();
             _calculatorService = new CalculeteService(_logger);
        }

        [Fact]
        public async Task CalculeteCDB_ShouldCalculateValues_ReturnSucesso()
        {

            // Arrange           
            CalculateResquestDto request = new(1000, 12);                       

            // Act
            var result = await _calculatorService.CalculeteCDB(request, CancellationToken.None);

            // Assert
            Assert.NotNull(result);          
        }

        [Theory]
        [InlineData(1000, 6,  1059.76, 1046.31)]
        [InlineData(1000, 12, 1123.08, 1098.47)]
        [InlineData(1000, 24, 1261.31, 1215.58)]
        [InlineData(1000, 25, 1273.57, 1232.54)]
        public async Task CalculeteCDB_ShouldCalculateWithDifferentMonths_ReturnSucesso(decimal valueInitial, int months, decimal grossValue, decimal netValue)
        {

            // Arrange           
            CalculateResquestDto request = new(valueInitial, months);           

            // Act
            var result = await _calculatorService.CalculeteCDB(request, CancellationToken.None);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(grossValue.ToString(), result.GrossValue);
            Assert.Equal(netValue.ToString(), result.NetValue);
        }
    }
}
