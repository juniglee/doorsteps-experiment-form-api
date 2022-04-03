using DoorstepsExperimentForm.DAL.Model;
using System.Threading.Tasks;

namespace DoorstepsExperimentForm.DAL.Interface
{
    public interface IAnswerRepository
    {
        Task Post(Answer answer);
    }
}
