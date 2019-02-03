using System.Threading.Tasks;
using MyProject2.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyProject2.Web.Tests.Controllers
{
    public class HomeController_Tests: MyProject2WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
