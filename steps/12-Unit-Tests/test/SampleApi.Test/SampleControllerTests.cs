using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Options;
using Moq;
using SampleApi.Configuration;
using SampleApi.Controllers;
using SampleApi.OutputModels;
using Xunit;

namespace SampleApi.Test
{
    public class SampleControllerTests
    {
        [Fact]
        public void Hello_Should_ReturnExpectedWelcomeMessage()
        {
            const string welcomeMessage = "TEST";
            const string name = "Bob";

            var expectedWelcome = $"{welcomeMessage} {name}";

            var mockOptions = new Mock<IOptions<MessagesConfiguration>>();
            mockOptions.Setup(x => x.Value).Returns(new MessagesConfiguration { WelcomeMessage = welcomeMessage });

            var sut = new SampleController(mockOptions.Object, new NullLogger<SampleController>());

            var actionResult = sut.Hello(name);

            var okResult = actionResult.Result.Should().BeAssignableTo<OkObjectResult>()
                .Which.Value.Should().BeAssignableTo<HelloOutputModel>()
                    .Which.WelcomeMessage.Should().Be(expectedWelcome);
        }
    }
}
