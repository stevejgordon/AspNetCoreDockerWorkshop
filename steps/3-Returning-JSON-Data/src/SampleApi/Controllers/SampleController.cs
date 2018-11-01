using Microsoft.AspNetCore.Mvc;
using SampleApi.OutputModels;

namespace SampleApi.Controllers
{
    [ApiController]
    public class SampleController : Controller
    {
        [Route("")]
        public ActionResult<string> Hello()
        {
            var model = new HelloOutputModel();
            return Ok(model);
        }
    }
}
