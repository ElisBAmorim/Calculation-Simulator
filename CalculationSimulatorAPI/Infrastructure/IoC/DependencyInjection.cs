using CalculationSimulatorAPI.Application.Dtos;
using CalculationSimulatorAPI.Dominio.Interfaces;
using CalculationSimulatorAPI.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace CalculationSimulatorAPI.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICalculeteService, CalculeteService>();

            return services;
        }

        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Title = Assembly.GetExecutingAssembly().GetName().Name,
                    Version = "v1",
                });
            });          
            return services;
        }

        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();         

            services.AddValidatorsFromAssemblyContaining<CalculateResquestDto>();

            return services;
        }
    }
}
