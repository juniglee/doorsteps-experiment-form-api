using DoorstepsExperimentForm.DAL.Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorstepsExperimentForm.BLL.Interface
{
    public interface IFormService
    {
        Task<Form> Get(string url);
        Task<IEnumerable<Form>> Get();
        Task Post(List<Form> forms);
        Task Delete(string id);
    }
}
