using CalculationSimulatorAPI.Infra.IoC;
using CalculationSimulatorAPI.Infrastructure.Validators;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace CalculationSimulatorAPI.Tests.Infrastructure
{
    public class DependencyInjectionTests
    {
        [Fact]
        public void AddServices_ShouldRegisterCalculeteService_Sucesso()
        {
            // Arrange           
            var services = new ServiceCollection();

            // Act
            services.AddServices();

            // Assert
            services.BuildServiceProvider().Should().NotBeNull();         
        }

        [Fact]
        public void AddSwagger_ShouldConfigureSwagger_Sucesso()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddSwagger();

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var swaggerGenOptions = serviceProvider.GetService<ISchemaGenerator>();
            swaggerGenOptions.Should().NotBeNull();         
        }

        [Fact]
        public void AddValidators_ShouldRegisterValidators_Sucesso()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddValidators();

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var validators = serviceProvider.GetServices<CalculeteValidator>();
            validators.Should().NotBeEmpty();
           
        }
    }
}
