using System.Threading.Tasks;
using Something.Models.TokenAuth;
using Something.Web.Controllers;
using Shouldly;
using Xunit;

namespace Something.Web.Tests.Controllers
{
    public class HomeController_Tests: SomethingWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}