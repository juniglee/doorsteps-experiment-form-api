using System.Collections.Generic;
using System.Threading.Tasks;
using DoorstepsExperimentForm.DAL.Interface;
using DoorstepsExperimentForm.DAL.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DoorstepsExperimentForm.DAL.Repository
{
    public class FormRepository : IFormRepository
    {
        private readonly IMongoCollection<Form> _forms;

        public FormRepository(IMongoClient client)
        {
            var database = client.GetDatabase("doorsteps-experiment-form");
            var collection = database.GetCollection<Form>("Forms");

            _forms = collection;
        }

        public async Task<Form> Get(string url)
        {
            var filter = Builders<Form>.Filter.Eq(c => c.Url, url);
            return await _forms.Find(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Form>> Get()
        {
            return await _forms.Find(_ => true).ToListAsync();
        }

        public async Task Post(List<Form> forms)
        {
            var bulkOps = new List<WriteModel<Form>>();
            foreach (var form in forms)
            {
                if (form.Id == null)
                {
                    form.Id = ObjectId.GenerateNewId().ToString();
                }
                var upsertOne = new ReplaceOneModel<Form>(
                    Builders<Form>.Filter.Where(c => c.Id == form.Id),
                    form)
                { IsUpsert = true };
                bulkOps.Add(upsertOne);
            }
            await _forms.BulkWriteAsync(bulkOps);
        }

        public async Task Delete(string id)
        {
            await _forms.DeleteOneAsync(c => c.Id == id);
        }
    }
}
