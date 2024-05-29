namespace CalculationSimulatorAPI.Application.Dtos
{
    public class CalculateResquestDto
    {
        public CalculateResquestDto(decimal applicationValue, int numberOfMonths)
        {
            ApplicationValue = applicationValue;
            NumberOfMonths = numberOfMonths;
        }

        public decimal ApplicationValue { get; set; }
        public int NumberOfMonths { get; set; }
    }
}
