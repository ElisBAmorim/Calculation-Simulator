namespace CalculationSimulatorAPI.Dominio.Calculation
{
    public abstract class CalculationBase    
    {     
        internal const decimal RateCDI = (0.9M) /100;
        internal const decimal RateTB = (108M)/100;

        public decimal InitialValue { get; private set; }      
        public CalculationBase(decimal initialValue)
        {
            InitialValue = initialValue;           
        }             

        public decimal CalculateFinalValue(decimal valueInput)
        {
            return valueInput * (1 + (RateCDI * RateTB));           
        }
    }
}
