using Microsoft.AspNetCore.Mvc;
using SampleApi.InputModels;
using SampleApi.OutputModels;

namespace SampleApi.Controllers
{
    [ApiController]
    public class SampleController : ControllerBase
    {
        [Route("{name?}")]
        public ActionResult<HelloOutputModel> Hello(string name)
        {
            var model = new HelloOutputModel();
            model.WelcomeMessage = $"{model.WelcomeMessage} {name ?? "whoever you are!"}";
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
