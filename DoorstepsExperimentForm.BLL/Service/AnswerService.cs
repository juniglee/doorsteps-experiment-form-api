using DoorstepsExperimentForm.BLL.Interface;
using DoorstepsExperimentForm.DAL.Interface;
using DoorstepsExperimentForm.DAL.Model;
using System.Threading.Tasks;

namespace DoorstepsExperimentForm.BLL.Service
{
    public class AnswerService : IAnswerService
    {
        private IAnswerRepository _answerRepository;

        public AnswerService(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public async Task Post(Answer answer)
        {
            await _answerRepository.Post(answer);
        }
    }
}
