using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Repositories
{
    public class InstanceRepository : IRepository<Instance>
    {

        MongoContext mongoContext;

        public InstanceRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public void Create(Instance item)
        {
            mongoContext.Instances.InsertOne(item);
        }

        public void Delete(Instance item)
        {
            var filter = Builders<Instance>.Filter.Eq(s => s.CopyId, item.CopyId);
            mongoContext.Instances.DeleteOne(filter);
        }

        public Instance Get(string id)
        {
            var filter = Builders<Instance>.Filter.Eq(x => x.CopyId, id);
            return mongoContext.Instances.Find(filter).FirstOrDefault();
        }

        public IEnumerable<Instance> GetAll()
        {
            return mongoContext.Instances.Find((x) => true).ToList();
        }

        public void Update(Instance item)
        {
            var filter = Builders<Instance>.Filter.Eq(s => s.CopyId, item.CopyId);
            mongoContext.Instances.ReplaceOne(filter, item);
        }
    }
}
