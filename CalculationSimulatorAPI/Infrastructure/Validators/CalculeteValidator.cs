using CalculationSimulatorAPI.Application.Dtos;
using FluentValidation;

namespace CalculationSimulatorAPI.Infrastructure.Validators
{
    public class CalculeteValidator : AbstractValidator<CalculateResquestDto>
    {
        const string messagePositiveValue = "Only positive values are valid";
        const string messageNumberMonths = "Invalid value, the number of months must be greater than 1.";

        public CalculeteValidator()
        {
            RuleFor(request => request.ApplicationValue)
                .GreaterThan(0)
                .WithMessage(messagePositiveValue);

            RuleFor(request => request.NumberOfMonths)
                .GreaterThan(1)
                .WithMessage(messageNumberMonths);
        }
    }
}
