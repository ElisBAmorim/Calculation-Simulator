using CalculationSimulatorAPI.Application.Dtos;

namespace CalculationSimulatorAPI.Dominio.Interfaces
{
    public interface ICalculeteService
    {
        Task<CalculateResponseDto> CalculeteCDB(CalculateResquestDto request, CancellationToken cancellation);
    }
}
