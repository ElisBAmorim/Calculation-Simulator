using CalculationSimulatorAPI.Dominio.Calculation.CDB;
using CalculationSimulatorAPI.Dominio.Calculation.IR;
using CalculationSimulatorAPI.Dominio.Interfaces;
using CalculationSimulatorAPI.Dominio.Model;

namespace CalculationSimulatorAPI.Dominio.Facade
{
    public class FacadeCalculation
    {
        private readonly ILogger _logger;
        private readonly ICalculeCdb _calculatorCDB;
        private readonly ICalculeIR _calculatorIR;
        private readonly int _numberOfMonths;       
      
        /// <summary>
        /// Inicialização do facade
        /// </summary>
        /// <param name="numberOfMonths"></param>
        /// <param name="calculeCDB"></param>
        /// <param name="calculeIR"></param>
        /// <param name="logger"></param>
        public FacadeCalculation(ILogger logger, int numberOfMonths, decimal valueInitial)
        {
            _logger = logger;
            _numberOfMonths = numberOfMonths;
            _calculatorCDB = new CalculeCdb(_logger, valueInitial);
            _calculatorIR = new CalculeIR(_logger, valueInitial);
        }

        /// <summary>
        /// Calcular os valores finais do CDB com e sem IR
        /// </summary>
        public FacadeCalculationModel CalculateValuesCDB()
        {
            _logger.LogInformation("Calcular valor final CDB e Taxa IR");

            var cdbFinalValue = _calculatorCDB.CalculateValueCDB(_numberOfMonths);
            var incomeTaxValue = _calculatorIR.CalculateIncomeTax(cdbFinalValue, _numberOfMonths);

           return new(cdbFinalValue, incomeTaxValue);                       
        }
    }
}
