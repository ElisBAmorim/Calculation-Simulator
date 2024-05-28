using CalculationSimulatorAPI.Dominio.Interfaces;

namespace CalculationSimulatorAPI.Dominio.Facade
{
    public class FacadeCalculation
    {
        private readonly ILogger _logger;
        private readonly ICalculeCdb _calculatorCDB;
        private readonly ICalculeIR _calculatorIR;
        private readonly int _numberOfMonths;

        public decimal ResultGross { get; private set; }
        public decimal ResultNet { get; private set; }

        /// <summary>
        /// Inicialização do facade
        /// </summary>
        /// <param name="numberOfMonths"></param>
        /// <param name="calculeCDB"></param>
        /// <param name="calculeIR"></param>
        /// <param name="logger"></param>
        public FacadeCalculation(int numberOfMonths, ICalculeCdb calculeCDB, ICalculeIR calculeIR, ILogger logger)
        {
            _logger = logger;
            _numberOfMonths = numberOfMonths;
            _calculatorCDB = calculeCDB;
            _calculatorIR = calculeIR;           
        }

        /// <summary>
        /// Calcular os valores finais do CDB com e sem IR
        /// </summary>
        public void CalculateValuesCDB()
        {
            _logger.LogInformation("Calcular valor final CDB e Taxa IR");

            var cdbFinalValue = _calculatorCDB.CalculateValueCDB(_numberOfMonths);
            var incomeTaxValue = _calculatorIR.CalculateIncomeTax(cdbFinalValue, _numberOfMonths);


            ResultGross = cdbFinalValue;
            ResultNet = cdbFinalValue - incomeTaxValue;
            _logger.LogDebug("Lucro Bruto: {ResultGross}", ResultGross);
            _logger.LogDebug("Lucro Liquido: {ResultNet}", ResultNet);
        }
    }
}
