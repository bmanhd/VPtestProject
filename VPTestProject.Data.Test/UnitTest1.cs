using System;
using MediatR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace VPTestProject.Data.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mediator = new Mock<IMediator>();
            var orderRequest = new SaveOrderRequest();

            //orderRequest.TotalPrice = 55.5M; //From my understanding the price would be calculated FE so should be passed down to endpoint
            //orderRequest.ProductIds = new List<ProductDto>
            //{
            //    new ProductDto
            //    {
            //        Id = Guid.NewGuid(),
            //        ProductTypeId = Guid.NewGuid(),
            //        Price = 24.99M
            //    },
            //    new ProductDto
            //    {
            //        Id = Guid.NewGuid(),
            //        ProductTypeId = Guid.NewGuid(),
            //        Price = 24.99M
            //    }
            //};
        }
    }
}
