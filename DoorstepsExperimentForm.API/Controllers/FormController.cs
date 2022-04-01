using DoorstepsExperimentForm.BLL.Interface;
using DoorstepsExperimentForm.DAL.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoorstepsExperimentForm.API.Controllers
{
    [Route("api/{controller}")]
    public class FormController : Controller
    {
        private IFormService _formService;

        public FormController(IFormService formService)
        {
            _formService = formService;
        }

        [HttpGet]
        public async Task<IEnumerable<Form>> Get()
        {
            return await _formService.Get();
        }

        [HttpGet("{url}")]
        public async Task<Form> Get(string url)
        {
            return await _formService.Get(url);
        }
     }
}
