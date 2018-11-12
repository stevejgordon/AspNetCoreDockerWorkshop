using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [ApiController]
    public class SampleController : ControllerBase
    {
        [Route("")]
        public string Hello()
        {
            return "Hello";
        }
    }
}
