namespace CalculationSimulatorAPI.Dominio.Model
{
    public class FacadeCalculationModel
    {
        public FacadeCalculationModel(decimal resultFinal, decimal incomeTaxValue)
        {
            ResultGross = resultFinal;
            SetResultNet(incomeTaxValue);
        }

        public decimal ResultNet { get; private set; }
        public decimal ResultGross { get; private set; }

        private void SetResultNet(decimal incomeTaxValue)
        {
            ResultNet = ResultGross - incomeTaxValue;
        }
    }
}
