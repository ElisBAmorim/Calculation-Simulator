
using CalculationSimulatorAPI.Aplication.Controllers.V1;
using CalculationSimulatorAPI.Application.Dtos;
using CalculationSimulatorAPI.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net;

namespace CalculationSimulatorAPI.Tests.Controller
{
    public class CalculateControllerTests
    {
        private readonly CalculateController _calculateController;
        private readonly Mock<ICalculeteService> _calculateService;

        public CalculateControllerTests()
        {
            _calculateService = new();
            _calculateController = new(_calculateService.Object);
        }

        [Fact]
        public async Task PostCalculeteCDB_ShouldReturnValues_ReturnSuccess()
        {
            //Arrange           
            CalculateResponseDto response = new(1012,1009);
            _calculateService.Setup(s=> s.CalculeteCDB(It.IsAny<CalculateResquestDto>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(response);


            //Act 
            var result = await _calculateController.Post(new CalculateResquestDto(1000,12), new CancellationToken());

            //Assert            
            ((ObjectResult)result).StatusCode.Equals(HttpStatusCode.OK);
            _calculateService.VerifyAll();
        }
    }
}
