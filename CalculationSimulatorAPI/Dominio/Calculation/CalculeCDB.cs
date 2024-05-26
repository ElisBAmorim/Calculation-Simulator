using CalculationSimulatorAPI.Dominio.Interfaces;

namespace CalculationSimulatorAPI.Dominio.Calculation
{
    public class CalculeCDB : CalculationBase, ICalculeCDB
    {     
        public CalculeCDB(decimal initialValue) : base(initialValue)
        {           
        }
  
        public decimal ValueCalculationCDB(int months)
        {
            decimal finalValue = InitialValue;

            for (int i = 0; i < months; i++)
            {
                finalValue = base.CalculateFinalValue(finalValue);
            }

            return finalValue;
        }

    }
}
