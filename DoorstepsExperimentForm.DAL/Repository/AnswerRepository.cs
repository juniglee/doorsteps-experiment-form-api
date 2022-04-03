using DoorstepsExperimentForm.DAL.Interface;
using DoorstepsExperimentForm.DAL.Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace DoorstepsExperimentForm.DAL.Repository
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly IMongoCollection<Answer> _answers;

        public AnswerRepository(IMongoClient client)
        {
            var database = client.GetDatabase("doorsteps-experiment-form");
            var collection = database.GetCollection<Answer>("Answers");

            _answers = collection;
        }
        public async Task Post(Answer answer)
        {
            if (answer.Id == null)
            {
                answer.Id = ObjectId.GenerateNewId().ToString();
                //await _answers.InsertOneAsync(answer);
            }
            await _answers.ReplaceOneAsync(Builders<Answer>.Filter.Where(c => c.Id == answer.Id), answer, new ReplaceOptions { IsUpsert = true});
        }
    }
}
