using System.Collections.Generic;
using System.Threading.Tasks;
using DoorstepsExperimentForm.BLL.Interface;
using DoorstepsExperimentForm.DAL.Interface;
using DoorstepsExperimentForm.DAL.Model;
using MongoDB.Bson;

namespace DoorstepsExperimentForm.BLL.Service
{
    public class FormService : IFormService
    {
        private IFormRepository _formRepository;

        public FormService(IFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        public async Task<Form> Get(string url)
        
        {
            return await _formRepository.Get(url);
        }

        public async Task<IEnumerable<Form>> Get()

        {
            return await _formRepository.Get();
        }
    }
}
