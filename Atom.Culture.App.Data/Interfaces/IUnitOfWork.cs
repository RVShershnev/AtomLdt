using Atom.Culture.App.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Interfaces
{
    public interface IUnitOfWork
    {
        public IRepository<Event> Events { get; }
        public IRepository<Book> Books { get; }
        public IRepository<Service> Services { get; }
        public IRepository<Organization> Organizations { get; }
        public IRepository<Issue> Issues { get; }
        public IRepository<Instance> Instances { get; }
        public IRepository<Reader> Readers { get; }
    }
}
