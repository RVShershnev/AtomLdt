using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Atom.Culture.App.Data.Repositories
{
    public class IssuesRepository : IRepository<Issue>
    {

        MongoContext mongoContext;

        public IssuesRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public void Create(Issue item)
        {
            mongoContext.Issues.InsertOne(item);
        }

        public void Delete(Issue item)
        {
            var filter = Builders<Issue>.Filter.Eq(s => s.IssueId, item.IssueId);
            mongoContext.Issues.DeleteOne(filter);
        }

        public Issue Get(string id)
        {
            var filter = Builders<Issue>.Filter.Eq(x => x.IssueId, id);
            return mongoContext.Issues.Find(filter).FirstOrDefault();
        }

        public IEnumerable<Issue> GetAll()
        {
            return mongoContext.Issues.Find((x) => true).ToList();
        }

        public void Update(Issue item)
        {
            var filter = Builders<Issue>.Filter.Eq(s => s.IssueId, item.IssueId);
            mongoContext.Issues.ReplaceOne(filter, item);
        }
    }
}
