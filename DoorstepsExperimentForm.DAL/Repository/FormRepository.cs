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
            return await _forms.Find(c => c.IsActive).ToListAsync();
        }
    }
}
