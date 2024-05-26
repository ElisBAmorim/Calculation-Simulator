using CalculationSimulatorAPI.Application.Dtos;

namespace CalculationSimulatorAPI.Dominio.Interfaces
{
    public interface ICalculeteService
    {
        Task<string> CalculeteCDB(CalculateResquestDto calculateResquest);
    }
}
