using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Atom.Culture.App.Data
{
    public class Class1
    {
        public void test()
        {
            //IUnitOfWork db = new MongoUnitOfWork("mongodb://localhost:27017/", "LctDB");
            MongoContext mongoContext = new MongoContext("mongodb://localhost:27017/", "LctDB");
            var reader = mongoContext.Readers.Find(Builders<Reader>.Filter.Eq(x => x.ReaderId, "179")).FirstOrDefault();
            var issues = mongoContext.Issues.Find(Builders<Issue>.Filter.Eq(x => x.ReaderIs, reader.ReaderId)).ToList().Select(x => x.BarCode);
            var instances = mongoContext.Instances.Find(Builders<Instance>.Filter.Where(x => issues.Contains(x.BarCode))).ToList().Select(x => x.CatalogRecordId);
            var books = mongoContext.Books.Find(Builders<Book>.Filter.Where(x => instances.Contains(x.DocId))).ToList();
            Person person = new Person()
            {
                Id = reader.ReaderId,
                BirthDate = reader.BirthDate,
                Books = books
            };

            //var reader = db.Readers.Get("179");
            //var issues = db.Issues.GetAll().Where(x => x.ReaderIs.Equals(reader.ReaderId));
            //var instances = db.Instances.GetAll().Where(x => issues.Select(x => x.BarCode).Contains(x.BarCode));
            //var books = db.Books.GetAll().Where(x => instances.Select(x => x.CatalogRecordId).Contains(x.DocId));
            //foreach (var book in books)
            //{
            //    Debug.WriteLine(book.Name);
            //}
        }
    }
}
