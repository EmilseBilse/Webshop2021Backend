using System.Collections.Generic;
using BilseTech.Webshop2021.Core.IServices;
using BilseTech.Webshop2021.Core.Models;
using Moq;
using Xunit;

namespace BilseTech.Webshop2021.Core.Test.IServices
{
    public class IProductServiceTest
    {
        [Fact]
        public void IProductService_Exists()
        {
            var serviceMock = new Mock<IProductService>();
            Assert.NotNull(serviceMock.Object);
        }

        [Fact]
        public void GetAll_WithNoParams_ReturnsListOfProducts()
        {
            var serviceMock = new Mock<IProductService>();
            serviceMock.Setup(s => s.GetAll())
                .Returns(new List<Product>());
            Assert.NotNull(serviceMock.Object.GetAll());
        }
    }
}