using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Mongo;
using System;
using System.Linq;

namespace Atom.Culture.App.Data
{
    public class Class1
    {
        public void test()
        {
            IUnitOfWork db = new MongoUnitOfWork("mongodb://localhost:27017/", "LctDB");
            Recomendation bookRec = db.Books.Get("1");
            Book book;
            if (bookRec is Book)
                book = (Book)bookRec;
        }
    }
}
