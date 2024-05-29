using CalculationSimulatorAPI.Dominio.Constantes;

namespace CalculationSimulatorAPI.Dominio.Calculation.CDB
{
    public abstract class CalculationBase
    {     
        /// <summary>
        /// Valor inicial para o cálculo
        /// </summary>
        public decimal InitialValue { get; private set; }

        /// <summary>
        ///  Inicializa uma nova instância da classe CalculationBase com o valor inicial especificado.
        /// </summary>
        /// <param name="initialValue"></param>
        protected CalculationBase(decimal initialValue)
        {
            InitialValue = initialValue;         
        }

        /// <summary>
        /// Calcula o valor final com base no valor de entrada.
        /// </summary>
        /// <param name="valueInput"> valor de entrada </param>
        /// <returns></returns>
        public decimal CalculateFinalValue(decimal valueInput)
        {            
            return valueInput * (1 + (Constants.Taxs.CDI * Constants.Taxs.TB)); 
        }
    }
}
