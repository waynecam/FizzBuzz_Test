using Application.Contracts;
using Infrastructure.Services;
using Shouldly;

namespace FizzBuzz_Test.Tests
{
    public class ServiceCreatorTests
    {
        [Fact]
        public void GetFBServiceSuccessTest()
        {
            IServiceCreator<IFBService> serviceCreator = new ServiceCreator<IFBService>();

            var instance = serviceCreator.GetInstance("","","");

            instance.ShouldBeOfType<FBService>();
        }
    }
}