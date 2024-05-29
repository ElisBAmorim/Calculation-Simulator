namespace CalculationSimulatorAPI.Application.Dtos
{
    public class CalculateResponseDto
    {
        public CalculateResponseDto(decimal grossValue, decimal netValue)
        {
            GrossValue = grossValue.ToString("F2");
            NetValue = netValue.ToString("F2");
        }

        public string GrossValue { get; set; }
        public string NetValue { get; set; }

    }
}
