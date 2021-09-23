using System;

namespace Config.Models
{
    public class MongodbSettings : IMongodbSettings
    {
        public string BooksCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IMongodbSettings
    {
        string BooksCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
