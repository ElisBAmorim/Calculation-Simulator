using CalculationSimulatorAPI.Dominio.Interfaces;
using System;

namespace CalculationSimulatorAPI.Dominio.Calculation.CDB
{
    public class CalculeCdb : CalculationBase, ICalculeCdb
    {
        private readonly ILogger _logger;
        public CalculeCdb(ILogger logger, decimal initialValue) : base(initialValue)
        {
            _logger = logger;
        }

        /// <summary>
        /// Calcula o valor final do CDB após um determinado número de meses.
        /// </summary>
        /// <param name="months">número de meses</param>
        /// <returns></returns>
        public decimal CalculateValueCDB(int months)
        {
            decimal finalValue = InitialValue;

            _logger.LogDebug("Valor Inicial: {InitialValue}", InitialValue);

            for (int i = 0; i < months; i++)
            {
                finalValue = Math.Round(CalculateFinalValue(finalValue),6, MidpointRounding.ToEven);              

                _logger.LogDebug("Novo valor: {FinalValue} - Mes: {Mes}", finalValue, i);
            }

            return finalValue;
        }
    }
}
