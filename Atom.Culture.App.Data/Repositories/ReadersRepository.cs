using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Atom.Culture.App.Data.Repositories
{
    public class ReadersRepository : IRepository<Reader>
    {
        MongoContext mongoContext;

        public ReadersRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public void Create(Reader item)
        {
            mongoContext.Readers.InsertOne(item);
        }

        public void Delete(Reader item)
        {
            var filter = Builders<Reader>.Filter.Eq(s => s.ReaderId, item.ReaderId);
            mongoContext.Readers.DeleteOne(filter);
        }

        public Reader Get(string id)
        {
            var filter = Builders<Reader>.Filter.Eq(x => x.ReaderId, id);
            return mongoContext.Readers.Find(filter).FirstOrDefault();
        }

        public IEnumerable<Reader> GetAll()
        {
            return mongoContext.Readers.Find((x) => true).ToList();
        }

        public void Update(Reader item)
        {
            var filter = Builders<Reader>.Filter.Eq(s => s.ReaderId, item.ReaderId);
            mongoContext.Readers.ReplaceOne(filter, item);
        }
    }
}
