using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [ApiController]
    public class SampleController : Controller
    {
        [Route("")]
        public ActionResult<string> Hello()
        {
            return "Hello";
        }
    }
}
