using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Repositories
{
    public class OrganizationsRepository : IRepository<Organization>
    {
        MongoContext mongoContext;

        public OrganizationsRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public void Create(Organization item)
        {
            mongoContext.Organizations.InsertOne(item);
        }

        public void Delete(Organization item)
        {
            var filter = Builders<Organization>.Filter.Eq(s => s.OrgId, item.OrgId);
            mongoContext.Organizations.DeleteOne(filter);
        }

        public Organization Get(string id)
        {
            var filter = Builders<Organization>.Filter.Eq(x => x.OrgId, id);
            return mongoContext.Organizations.Find(filter).FirstOrDefault();
        }

        public IEnumerable<Organization> GetAll()
        {
            return mongoContext.Organizations.Find((x) => true).ToList();
        }

        public void Update(Organization item)
        {
            var filter = Builders<Organization>.Filter.Eq(s => s.OrgId, item.OrgId);
            mongoContext.Organizations.ReplaceOne(filter, item);
        }
    }
}
