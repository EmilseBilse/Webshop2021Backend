using BilseTech.Webshop2021.Core.Models;
using Xunit;

namespace BilseTech.Webshop2021.Core.Test.Models
{
    public class ProductTest
    {
        [Fact]
        public void Product_Exists()
        {
            var product = new Product();
            Assert.NotNull(product);
        }

        [Fact]
        public void Product_HasStringProperty_Name()
        {
            var p = new Product();
            p.Name = "joe";
            Assert.Equal("joe", p.Name);
        }
        
        [Fact]
        public void Product_HasIntProperty_Id()
        {
            var p = new Product();
            p.Id = 1;
            Assert.Equal(1,p.Id);
        }
    }
}
