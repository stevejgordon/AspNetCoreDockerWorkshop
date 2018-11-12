using Microsoft.AspNetCore.Mvc;
using SampleApi.OutputModels;

namespace SampleApi.Controllers
{
    [ApiController]
    public class SampleController : Controller
    {
        [Route("{name?}")]
        public ActionResult<HelloOutputModel> Hello(string name)
        {
            var model = new HelloOutputModel();
            model.WelcomeMessage = $"{model.WelcomeMessage} {name ?? "whoever you are!"}";
            return Ok(model);
        }
    }
}
