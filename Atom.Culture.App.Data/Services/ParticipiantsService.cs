using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;

namespace Atom.Culture.App.Data.Services
{
    public class ParticipiantsService : IEntityService<Participiant>
    {
        MongoContext mongo;

        public ParticipiantsService(MongoContext mongo)
        {
            this.mongo = mongo;
        }

        public void Create(Participiant item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Participiant item)
        {
            throw new NotImplementedException();
        }

        public Participiant Get(string id)
        {
            Participiant participiant = new Participiant();
            var pupil = mongo.Pupils.Find(Builders<Pupil>.Filter.Eq(x => x.PupilId, id));

            throw new NotImplementedException();
        }

        public void Update(Participiant item)
        {
            throw new NotImplementedException();
        }
    }
}
