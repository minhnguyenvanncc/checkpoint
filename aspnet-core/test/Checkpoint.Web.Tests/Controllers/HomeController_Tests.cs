using System.Threading.Tasks;
using Checkpoint.Models.TokenAuth;
using Checkpoint.Web.Controllers;
using Shouldly;
using Xunit;

namespace Checkpoint.Web.Tests.Controllers
{
    public class HomeController_Tests: CheckpointWebTestBase
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