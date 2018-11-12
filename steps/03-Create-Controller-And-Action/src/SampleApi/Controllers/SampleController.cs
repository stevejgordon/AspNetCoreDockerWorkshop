using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [ApiController]
    public class SampleController : Controller
    {
        [Route("")]
        public string Hello()
        {
            return "Hello";
        }
    }
}
