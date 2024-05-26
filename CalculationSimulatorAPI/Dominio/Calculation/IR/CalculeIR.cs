using CalculationSimulatorAPI.Dominio.Interfaces;

namespace CalculationSimulatorAPI.Dominio.Calculation.IR
{
    public class CalculeIR : ICalculeIR
    {
        protected const decimal TaxRateUp6 = 22.5M / 100;
        protected const decimal TaxRateUp12 = 20M / 100;
        protected const decimal TaxRateUp24 = 17.5M / 100;
        protected const decimal TaxRateThan24 = 15M / 100;
       
        private decimal _initialValue;

        public CalculeIR(decimal initialValue)
        {
            _initialValue = initialValue;
        }

        /// <summary>
        /// Calcula o Imposto de Renda com base no ganho de capital.
        /// </summary>
        /// <param name="initialValue"></param>
        /// <param name="finalValue"></param>
        /// <param name="months"></param>
        /// <returns></returns>
        public decimal CalculateIncomeTax(decimal finalValue, int months)
        {
            decimal grossProfit = finalValue - _initialValue;
            return CalculateValueRateIR(grossProfit, GetTaxRate(months));
        }

        /// <summary>
        /// Obtém a taxa de imposto com base no período de investimento.
        /// </summary>
        /// <param name="months"></param>
        /// <returns></returns>
        private decimal GetTaxRate(int months)
        {
            switch (months)
            {
                case <= 6: return TaxRateUp6;
                case <= 12: return TaxRateUp12;
                case <= 24: return TaxRateUp24;
                default: return TaxRateThan24;
            }
        }

        /// <summary>
        /// Calcula o valor do Imposto de Renda.
        /// </summary>
        /// <param name="grossProfit"></param>
        /// <param name="taxRateIR"></param>
        /// <returns></returns>
        public decimal CalculateValueRateIR(decimal grossProfit, decimal taxRateIR)
        {
            return grossProfit * taxRateIR;
        }

    }
}
