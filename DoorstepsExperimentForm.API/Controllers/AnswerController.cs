using DoorstepsExperimentForm.BLL.Interface;
using DoorstepsExperimentForm.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DoorstepsExperimentForm.API.Controllers
{
    [Route("api/{controller}")]
    public class AnswerController : Controller
    {
        private IAnswerService _answerService;

        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        /*[HttpGet]
        public async Task<IEnumerable<Form>> Get()
        {
            return await _formService.Get();
        }

        [HttpGet("{url}")]
        public async Task<Form> Get(string url)
        {
            return await _formService.Get(url);
        }*/

        [HttpPost]
        public async Task Post([FromBody] Answer answer)
        {
            await _answerService.Post(answer);
        }

        /*[HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _formService.Delete(id);
        }*/
    }
}
