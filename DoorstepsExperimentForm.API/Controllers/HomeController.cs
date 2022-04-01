using Microsoft.AspNetCore.Mvc;

namespace DoorstepsExperimentFormApi.Controllers
{
    [Route("api/{controller}")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "Hello World";
        }
    }
}
