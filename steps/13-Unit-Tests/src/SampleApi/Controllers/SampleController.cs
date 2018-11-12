using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<SampleController> _logger;

        public SampleController(IOptions<MessagesConfiguration> messagesConfig, ILogger<SampleController> logger)
        {
            _messagesConfig = messagesConfig;
            _logger = logger;
        }

        [Route("{name?}")]
        public ActionResult<HelloOutputModel> Hello(string name)
        {
            var model = new HelloOutputModel();
            model.WelcomeMessage = $"{_messagesConfig.Value.WelcomeMessage} {name ?? "whoever you are!"}";
            return Ok(model);}

        [HttpPost]
        [Route("calculate")]
        public ActionResult<CalculateOutputModel> Calculate(CalculateInputModel input)
        {
            var result = new CalculateOutputModel();

            try
            {
                result.Result = input.Number1 + input.Number2;
                _logger.LogInformation("Successfully calculated a result");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to calculate a result");
            }
            return Ok(result);
        }
    }
}
