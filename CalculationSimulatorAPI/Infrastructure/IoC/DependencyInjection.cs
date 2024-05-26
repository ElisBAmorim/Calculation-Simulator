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
        /// <summary>
        /// Registra os serviços no contêiner de injeção de dependência.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICalculeteService, CalculeteService>();

            return services;
        }

        /// <summary>
        /// Configura o Swagger para gerar a documentação da API.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
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

        /// <summary>
        ///  Registra os validadores de entrada usando o FluentValidation.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddValidators(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();         

            services.AddValidatorsFromAssemblyContaining<CalculateResquestDto>();

            return services;
        }
    }
}
