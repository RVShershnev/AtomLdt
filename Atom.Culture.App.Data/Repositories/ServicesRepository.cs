using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Atom.Culture.App.Data.Repositories
{
    public class ServicesRepository : IRepository<Service>
    {
        MongoContext mongoContext;

        public ServicesRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public void Create(Service item)
        {
            mongoContext.Services.InsertOne(item);
        }

        public void Delete(Service item)
        {
            var filter = Builders<Service>.Filter.Eq(s => s.ServId, item.ServId);
            mongoContext.Services.DeleteOne(filter);
        }

        public Service Get(string id)
        {
            var filter = Builders<Service>.Filter.Eq(x => x.ServId, id);
            return mongoContext.Services.Find(filter).FirstOrDefault();
        }

        public IEnumerable<Service> GetAll()
        {
            return mongoContext.Services.Find((x) => true).ToList();
        }

        public void Update(Service item)
        {
            var filter = Builders<Service>.Filter.Eq(s => s.ServId, item.ServId);
            mongoContext.Services.ReplaceOne(filter, item);
        }
    }
}
