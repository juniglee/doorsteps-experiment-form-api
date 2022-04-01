using DoorstepsExperimentForm.DAL.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoorstepsExperimentForm.DAL.Interface
{
    public interface IFormRepository
    {
        Task<Form> Get(string url);
        Task<IEnumerable<Form>> Get();
        Task Post(List<Form> forms);
    }
}
