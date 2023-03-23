using Application.Contracts;
using Infrastructure.Services;
using Moq;
using Shouldly;

namespace FizzBuzz_Test.Tests
{
    public class FBServiceTests
    {

        Mock<IServiceCreator<IFBService>> _mockServiceCreator;

        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(3, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(1, "1")]
        [InlineData(98, "98")]
        public void FizzBuzzCalculationTest(int input, string expectedResult)
        {
            _mockServiceCreator = new Mock<IServiceCreator<IFBService>>();

            _mockServiceCreator.Setup(x => x.GetInstance(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>()))
                 .Returns(new FBService());

            var fbService = _mockServiceCreator.Object.GetInstance("", "", "");

            var result = fbService?.CalculateFizzBuzzResult(input);

            result.ShouldBe(expectedResult);



        }
    }
}