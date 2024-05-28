using CalculationSimulatorAPI.Application.Dtos;
using CalculationSimulatorAPI.Infrastructure.Validators.Helper;
using FluentValidation;

namespace CalculationSimulatorAPI.Infrastructure.Validators
{
    public  class CalculeteValidator : AbstractValidator<CalculateResquestDto>
    {        
        /// <summary>
        /// Realiza a validação dos valores de request 
        /// ApplicationValue : Somente valores positivos são válidos.
        /// NumberOfMonths: o número de meses deve ser maior que 1.
        /// </summary>
        public CalculeteValidator()
        {
            RuleFor(request => request.ApplicationValue)
                .GreaterThan(0)
                .WithMessage(ValidatorHelper.MessagePositiveValue);

            RuleFor(request => request.NumberOfMonths)
                .GreaterThan(1)
                .WithMessage(ValidatorHelper.MessageNumberMonths);
        }
    }
}
