using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Moq;
using VPTestProject.Data.EF.Dto;
using VPTestProject.Data.EF.Helpers;
using VPTestProject.Data.EF.Models.Models;
using VPTestProject.Data.EF.Requests;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace VPTestProject.Data.EF.Test
{
    [TestClass]
    public class SaveOrderTests(OrderTestFixture fixture) : IClassFixture<OrderTestFixture>
    {
        //private readonly Mock<IMediator> _mediator = new();
        private readonly Mock<IValidator<SaveOrderRequest>> _validator = new();
        private readonly CustomerHelper _customerHelper = new();
        private readonly OrderTestFixture _fixture = fixture;
        private readonly Guid _customerId = Guid.NewGuid();

        [Fact]
        public async void SaveOrderTest()
        {
            //Arrange

            var orderRequest = new SaveOrderRequest();

            orderRequest.TotalPrice = 55.5M; //From my understanding the price would be calculated FE so should be passed down to endpoint
            orderRequest.Products = new List<ProductDto>
            {
                new ProductDto
                {
                    Id = Guid.NewGuid(),
                    ProductTypeId = Guid.NewGuid(),
                    Price = 24.99M
                },
                new ProductDto
                {
                    Id = Guid.NewGuid(),
                    ProductTypeId = Guid.NewGuid(),
                    Price = 24.99M
                }
            };
            orderRequest.Customer = new CustomerDto
            {
                Id = _customerId,
                FirstName = "John",
                LastName = "Smith"
            };

            var handler = new SaveOrderHandler(_fixture.EfDatabaseContext, _customerHelper, _validator.Object);

            //Act
            var result = await handler.Handle(orderRequest, new System.Threading.CancellationToken());

            Assert.IsNotNull(result);
        }

        
    }
}