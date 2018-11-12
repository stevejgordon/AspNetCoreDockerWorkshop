using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SampleApi.Configuration;
using SampleApi.InputModels;
using SampleApi.OutputModels;

namespace SampleApi.Controllers
{
    [ApiController]
    public class SampleController : Controller
    {
        private readonly IOptions<MessagesConfiguration> _messagesConfig;

        public SampleController(IOptions<MessagesConfiguration> messagesConfig)
        {
            _messagesConfig = messagesConfig;
        }

        [Route("{name?}")]
        public ActionResult<HelloOutputModel> Hello(string name)
        {
            var model = new HelloOutputModel();
            model.WelcomeMessage = $"{_messagesConfig.Value.WelcomeMessage} {name ?? "whoever you are!"}";
            return Ok(model);
        }

        [HttpPost]
        [Route("calculate")]
        public ActionResult<CalculateOutputModel> Calculate(CalculateInputModel input)
        {
            var result = new CalculateOutputModel { Result = input.Number1 + input.Number2 };
            return Ok(result);
        }
    }
}
