using CalculationSimulatorAPI.Dominio.Interfaces;

namespace CalculationSimulatorAPI.Dominio.Calculation
{
    public class CalculeCDB : CalculationBase, ICalculeCDB
    {     
        public CalculeCDB(decimal initialValue) : base(initialValue)
        {           
        }

        public decimal ValueCalculationCDB()
        {
            return base.CalculateFinalValue();
        }

    }
}
