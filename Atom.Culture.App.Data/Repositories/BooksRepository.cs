using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System.Collections.Generic;

namespace Atom.Culture.App.Data.Repositories
{
    public class BooksRepository : IRepository<Book>
    {

        MongoContext mongoContext;

        public BooksRepository(MongoContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public void Create(Book item)
        {
            mongoContext.Books.InsertOne(item);
        }

        public void Delete(Book item)
        {
            var filter = Builders<Book>.Filter.Eq(s => s.DocId, item.DocId);
            mongoContext.Books.DeleteOne(filter);
        }

        public Book Get(string id)
        {
            var filter = Builders<Book>.Filter.Eq(x => x.DocId, id);
            return mongoContext.Books.Find(filter).FirstOrDefault();
        }

        public IEnumerable<Book> GetAll()
        {
            return mongoContext.Books.Find((x) => true).ToList();
        }

        public void Update(Book item)
        {
            var filter = Builders<Book>.Filter.Eq(s => s.DocId, item.DocId);
            mongoContext.Books.ReplaceOne(filter, item);
        }
    }
}
