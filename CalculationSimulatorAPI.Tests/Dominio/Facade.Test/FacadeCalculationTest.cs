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
            _facade = new(12, _calculatorCDB.Object, _calculatorIR.Object, _logger);
        }

        [Fact]
        public void CalculateValuesCDB_ShouldCalculateCorrectly()
        {
            // Arrange 
            _calculatorCDB.Setup(s=> s.CalculateValueCDB(It.IsAny<int>())).Returns(1123);
            _calculatorIR.Setup(s => s.CalculateIncomeTax(It.IsAny<decimal>(),It.IsAny<int>())).Returns(1098);
            
            // Act
            _facade.CalculateValuesCDB();

            // Assert
            Assert.Equal("1123", _facade.ResultGross.ToString());
            Assert.Equal("25", _facade.ResultNet.ToString());

            _calculatorCDB.Verify();
            _calculatorCDB.Verify(v=> v.CalculateValueCDB(It.IsAny<int>()),Times.Once);
            _calculatorIR.Verify();
            _calculatorIR.Verify(v=> v.CalculateIncomeTax(It.IsAny<decimal>(),It.IsAny<int>()),Times.Once);

        }
    }
}
