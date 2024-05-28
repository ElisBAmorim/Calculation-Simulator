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
        /// <param name="numberOfMonths"> número de meses </param>
        /// <param name="calculeCDB"> instancia da classe CalculeCDB </param>
        /// <param name="calculeIR"> instancia da classe CalculeIR </param>
        /// <exception cref="ArgumentNullException"></exception>
        public FacadeCalculation(int numberOfMonths, ICalculeCdb calculeCDB, ICalculeIR calculeIR, ILogger logger)
        {
            _logger = logger;
            _numberOfMonths = numberOfMonths;
            _calculatorCDB = calculeCDB ?? throw new ArgumentNullException(nameof(calculeCDB), "The instance of ICalculeCBD cannot be null.");
            _calculatorIR = calculeIR ?? throw new ArgumentNullException(nameof(calculeIR), "The instance of ICalculeIR cannot be null.");
          
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
