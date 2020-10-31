using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Linq;

namespace Atom.Culture.App.Data.Services
{
    public class PersonsService : IPersonsService
    {
        MongoContext mongo;

        public PersonsService(string connectionString, string dbName)
        {
            mongo = new MongoContext(connectionString, dbName);
        }

        public Person Get(string id)
        {
            var reader = mongo.Readers.Find(Builders<Reader>.Filter.Eq(x => x.ReaderId, id)).FirstOrDefault();
            var issues = mongo.Issues.Find(Builders<Issue>.Filter.Eq(x => x.ReaderIs, reader.ReaderId)).ToList().Select(x => x.BarCode);
            var instances = mongo.Instances.Find(Builders<Instance>.Filter.Where(x => issues.Contains(x.BarCode))).ToList().Select(x => x.CatalogRecordId);
            var books = mongo.Books.Find(Builders<Book>.Filter.Where(x => instances.Contains(x.DocId))).ToList();
            Person person = new Person()
            {
                Id = reader.ReaderId,
                BirthDate = reader.BirthDate,
                Books = books
            };
            return person;
        }
    }
}
