using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace DoorstepsExperimentForm.DAL.Model
{
    public class Form
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public IEnumerable<Question> Questions { get; set; }
    }

    public class Question
    {
        public string QuestionName { get; set; }
        public string QuestionControlName { get; set; }
        public string QuestionType { get; set; }

        public IEnumerable<Option> Options { get; set; }
    }

    public class Option
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }
}
