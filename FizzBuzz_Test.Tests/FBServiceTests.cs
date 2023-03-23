using Application.Contracts;
using Infrastructure.Services;
using Moq;
using Shouldly;

namespace FizzBuzz_Test.Tests
{
    public class FBServiceTests
    {

        Mock<IServiceCreator<IFBService>> _mockServiceCreator;

        [Fact]
        public void FizzBuzzCalculationTest()
        {
            _mockServiceCreator = new Mock<IServiceCreator<IFBService>>();

            _mockServiceCreator.Setup(x => x.GetInstance(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                 .Returns(new FBService());

            var fbService = _mockServiceCreator.Object.GetInstance("", "", "");

            var result = fbService?.CalculateFizzBuzzResult(15);

            result.ShouldBe("FizzBuzz");



        }
    }
}