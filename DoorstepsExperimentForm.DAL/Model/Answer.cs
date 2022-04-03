using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System.Collections.Generic;

namespace DoorstepsExperimentForm.DAL.Model
{
    public class Answer
    {
        [BsonId(IdGenerator = typeof(ObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Form { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IEnumerable<AdditionalAnswer> AdditionalAnswers { get; set; }
    }

    public class AdditionalAnswer
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
