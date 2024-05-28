using CalculationSimulatorAPI.Dominio.Constantes;
using CalculationSimulatorAPI.Dominio.Interfaces;

namespace CalculationSimulatorAPI.Dominio.Calculation.IR
{
    public class CalculeIR : ICalculeIR
    {       
        private readonly ILogger _logger;
        private readonly decimal _initialValue;

        /// <summary>
        /// contrutor da classe
        /// </summary>
        /// <param name="initialValue"> valor inicial de entrada </param>
        public CalculeIR(ILogger logger, decimal initialValue)
        {
            _initialValue = initialValue;
            _logger = logger;
        }

        /// <summary>
        /// Calcula o Imposto de Renda com base no ganho de capital.
        /// </summary>
        /// <param name="finalValue"> valor final do calculo</param>
        /// <param name="months">número de meses</param>
        /// <returns></returns>
        public decimal CalculateIncomeTax(decimal finalValue, int months)
        {
            decimal grossProfit = finalValue - _initialValue;
                      
            _logger.LogDebug("Lucro bruto: {GrossProfit}", grossProfit);

            return CalculateValueRateIR(grossProfit, GetTaxRate(months));
        }

        /// <summary>
        /// Obtém a taxa de imposto com base no período de investimento.
        /// </summary>
        /// <param name="months">número de meses</param>
        /// <returns></returns>
        private static decimal GetTaxRate(int months)
        {
            return months switch
            {
                <= 6 => Constants.TaxIncome.TaxRateUp6,
                <= 12 => Constants.TaxIncome.TaxRateUp12,
                <= 24 => Constants.TaxIncome.TaxRateUp24,
                _ => Constants.TaxIncome.TaxRateThan24,
            };
        }

        /// <summary>
        /// Calcula o valor do Imposto de Renda.
        /// </summary>
        /// <param name="grossProfit">lucro bruto </param>
        /// <param name="taxRateIR"> Taxa do IR </param>
        /// <returns></returns>
        public decimal CalculateValueRateIR(decimal grossProfit, decimal taxRateIR)
        {
            _logger.LogDebug("Valor da Taxa IR: {TaxaIR}", grossProfit * taxRateIR);
            return grossProfit * taxRateIR;
        }

    }
}
