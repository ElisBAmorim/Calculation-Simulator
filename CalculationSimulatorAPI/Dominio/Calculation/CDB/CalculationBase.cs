namespace CalculationSimulatorAPI.Dominio.Calculation.CDB
{
    public abstract class CalculationBase
    {       
        /// <summary>
        /// Taxas CDI e TB
        /// </summary>
        protected const decimal RateCDI = 0.9M / 100;
        protected const decimal RateTB = 108M / 100;        
       
        /// <summary>
        /// Valor inicial para o cálculo
        /// </summary>
        public decimal InitialValue { get; private set; }

        /// <summary>
        ///  Inicializa uma nova instância da classe CalculationBase com o valor inicial especificado.
        /// </summary>
        /// <param name="initialValue"></param>
        public CalculationBase(decimal initialValue)
        {
            InitialValue = initialValue;         
        }

        /// <summary>
        /// Calcula o valor final com base no valor de entrada.
        /// </summary>
        /// <param name="valueInput"> valor de entrada </param>
        /// <returns></returns>
        public decimal CalculateFinalValue(Decimal valueInput)
        {            
            return valueInput * (1 + (RateCDI * RateTB)); 
        }
    }
}
