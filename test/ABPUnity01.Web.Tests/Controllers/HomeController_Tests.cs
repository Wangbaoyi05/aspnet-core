using System.Threading.Tasks;
using ABPUnity01.Models.TokenAuth;
using ABPUnity01.Web.Controllers;
using Shouldly;
using Xunit;

namespace ABPUnity01.Web.Tests.Controllers
{
    public class HomeController_Tests: ABPUnity01WebTestBase
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