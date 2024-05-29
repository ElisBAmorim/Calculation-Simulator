using CalculationSimulatorAPI.Application.Dtos;
using CalculationSimulatorAPI.Infrastructure.Validators;
using CalculationSimulatorAPI.Infrastructure.Validators.Helper;

namespace CalculationSimulatorAPI.Tests.Validator
{
    public class CalculeteValidatorTest
    {     
        public class CalculeteValidatorTests
        {
            private readonly CalculeteValidator _validator;

            public CalculeteValidatorTests()
            {
                _validator = new CalculeteValidator();
            }

            [Fact]
            public void ApplicationValue_ShouldHaveValidationError_WhenValueIsNegative()
            {
                // Arrange
                var request = new CalculateResquestDto(-100, 12);

                // Act
                var result  = _validator.Validate(request);

                //Assert
                Assert.False(result.IsValid);
                Assert.Equal(result.Errors.Single().ErrorMessage, ValidatorHelper.MessagePositiveValue);               
            }
            
            [Fact]
            public void ApplicationValue_ShouldNotHaveValidationError_WhenValueIsPositive()
            {
                // Arrange
                var request = new CalculateResquestDto(100, 12);
                                
                // Act
                var result = _validator.Validate(request);

                //Assert
                Assert.True(result.IsValid);
                Assert.Empty(result.Errors);
            }
            
            [Fact]
            public void NumberOfMonths_ShouldHaveValidationError_WhenValueIsLessThan2()
            {
                // Arrange
                var request = new CalculateResquestDto(100, 1);

                // Act
                var result = _validator.Validate(request);

                //Assert
                Assert.False(result.IsValid);
                Assert.Equal(result.Errors.Single().ErrorMessage, ValidatorHelper.MessageNumberMonths);
            }

            [Fact]
            public void NumberOfMonths_ShouldNotHaveValidationError_WhenValueIsGreaterThan1()
            {
                // Arrange
                var request = new CalculateResquestDto(100, 2);

                // Act
                var result = _validator.Validate(request);

                //Assert
                Assert.True(result.IsValid);
                Assert.Empty(result.Errors);
            }                
        }
    }
}
