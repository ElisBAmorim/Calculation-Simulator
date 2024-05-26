using CalculationSimulatorAPI.Dominio.Interfaces;

namespace CalculationSimulatorAPI.Dominio.Calculation.CDB
{
    public class CalculeCDB : CalculationBase, ICalculeCDB
    {
        public CalculeCDB(decimal initialValue) : base(initialValue) { }

        /// <summary>
        /// Calcula o valor final do CDB após um determinado número de meses.
        /// </summary>
        /// <param name="months"></param>
        /// <returns></returns>
        public decimal CalculateValueCDB(int months)
        {
            decimal finalValue = InitialValue;

            for (int i = 0; i < months; i++)
            {
                finalValue = CalculateFinalValue(finalValue);
            }

            return finalValue;
        }
    }
}
