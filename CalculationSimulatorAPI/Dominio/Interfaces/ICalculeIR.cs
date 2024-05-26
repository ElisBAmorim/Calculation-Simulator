namespace CalculationSimulatorAPI.Dominio.Interfaces
{
    public interface ICalculeIR
    {
        decimal CalculateIncomeTax(decimal finalValue, int months);
    }
}
