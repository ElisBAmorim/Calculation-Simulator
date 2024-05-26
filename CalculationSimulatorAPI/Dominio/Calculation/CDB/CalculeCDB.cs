using CalculationSimulatorAPI.Dominio.Interfaces;
using System;

namespace CalculationSimulatorAPI.Dominio.Calculation.CDB
{
    public class CalculeCDB : CalculationBase, ICalculeCDB
    {
        public CalculeCDB(decimal initialValue) : base(initialValue) { }

        /// <summary>
        /// Calcula o valor final do CDB após um determinado número de meses.
        /// </summary>
        /// <param name="months">número de meses</param>
        /// <returns></returns>
        public decimal CalculateValueCDB(int months)
        {
            Decimal finalValue = InitialValue;
            Console.WriteLine($"Value inicial: {InitialValue}");
            for (int i = 0; i < months; i++)
            {
                finalValue = CalculateFinalValue(finalValue);
                finalValue = Math.Round(finalValue, 10);
            }

            return finalValue;
        }
    }
}
