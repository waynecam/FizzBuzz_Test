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

            var instance = serviceCreator.GetInstance("Infrastructure.dll",
                "Application.Contracts.IFBService",
                "Infrastructure.Services.FBService");

            instance.ShouldBeOfType<FBService>();
        }



        [Fact]

        public void NonExistentServiceReturnsNullFBServiceSuccessTest()
        {
            IServiceCreator<IFBService> serviceCreator = new ServiceCreator<IFBService>();

            var instance = serviceCreator.GetInstance("Infrastructure.dll",
                "Application.Contracts.NONEXISTENTINTERFACE",
                "Infrastructure.Services.NONEXISTSERVICE");

            instance.ShouldBeOfType<NullFBService>();

        }
    }
}