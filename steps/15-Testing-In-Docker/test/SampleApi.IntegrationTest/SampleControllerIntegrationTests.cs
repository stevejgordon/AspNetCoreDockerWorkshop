using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace SampleApi.IntegrationTest
{
    public class SampleControllerIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private const string JsonContentType = "application/json; charset=utf-8";

        private readonly WebApplicationFactory<Startup> _factory;

        public SampleControllerIntegrationTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Hello_ReturnsExpectedContentType()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/Steve");

            response.EnsureSuccessStatusCode(); // Status Code 200-299
            response.Content.Headers.ContentType.ToString().Should().Be(JsonContentType);
        }
    }
}
