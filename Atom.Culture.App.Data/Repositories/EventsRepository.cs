using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Atom.Culture.App.Data.Repositories
{
    public class EventsRepository : IRepository<Event>
    {

        MongoContext mongoContext;

        public EventsRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public void Create(Event item)
        {
            mongoContext.Events.InsertOne(item);
        }

        public void Delete(Event item)
        {
            var filter = Builders<Event>.Filter.Eq(s => s.EvId, item.EvId);
            mongoContext.Events.DeleteOne(filter);
        }

        public Event Get(string id)
        {
            var filter = Builders<Event>.Filter.Eq(x => x.EvId, id);
            return mongoContext.Events.Find(filter).FirstOrDefault();
        }

        public IEnumerable<Event> GetAll()
        {
            return mongoContext.Events.Find((x) => true).ToList();
        }

        public void Update(Event item)
        {
            var filter = Builders<Event>.Filter.Eq(s => s.EvId, item.EvId);
            mongoContext.Events.ReplaceOne(filter, item);
        }
    }
}
