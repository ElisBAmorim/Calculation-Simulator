using CalculationSimulatorAPI.Dominio.Interfaces;
using CalculationSimulatorAPI.Dominio.Facade;
using Microsoft.Extensions.Logging;
using Moq;

namespace CalculationSimulatorAPI.Tests.Dominio.Facade.Test
{
    public class FacadeCalculationTest
    {     
        private readonly Mock<ICalculeCdb> _calculatorCDB = new();
        private readonly Mock<ICalculeIR> _calculatorIR = new();
        private readonly ILogger _logger;
        private readonly FacadeCalculation _facade;
      
        public FacadeCalculationTest()
        {           
            _logger = new LoggerFactory().CreateLogger<FacadeCalculation>();
            _facade = new(_logger, 12, 1000);
        }

        [Fact]
        public void CalculateValuesCDB_ShouldCalculateCorrectly_Sucesso()
        {           
            // Arrange 
             _calculatorCDB.Setup(s=> s.CalculateValueCDB(It.IsAny<int>())).Returns(1123);
             _calculatorIR.Setup(s => s.CalculateIncomeTax(It.IsAny<decimal>(),It.IsAny<int>())).Returns(1098);
            
            // Act
            var result = _facade.CalculateValuesCDB();

            // Assert
            Assert.NotNull(result);      
        
            _calculatorCDB.Verify();          
            _calculatorIR.Verify();           
        }
    }
}
