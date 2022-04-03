using DoorstepsExperimentForm.DAL.Model;
using System.Threading.Tasks;

namespace DoorstepsExperimentForm.BLL.Interface
{
    public interface IAnswerService
    {
        Task Post(Answer answer);
    }
}
