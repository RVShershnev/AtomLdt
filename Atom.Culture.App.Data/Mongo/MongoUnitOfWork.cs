using Atom.Culture.App.Data.Interfaces;
using Atom.Culture.App.Data.Models;
using Atom.Culture.App.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Mongo
{
    public class MongoUnitOfWork : IUnitOfWork
    {
        private MongoContext mongoContext;
        private IRepository<Event> events;
        private IRepository<Book> books;
        private IRepository<Service> services;
        private IRepository<Organization> organizations;
        private IRepository<Issue> issues;
        private IRepository<Instance> instances;
        private IRepository<Reader> readrs;

        public MongoUnitOfWork(string connectionString, string dbName)
        {
            mongoContext = new MongoContext(connectionString, dbName);
        }

        public IRepository<Event> Events
        {
            get
            {
                if (events == null)
                    events = new EventsRepository(mongoContext);
                return events;
            }
        }

        public IRepository<Book> Books
        {
            get
            {
                if (books == null)
                    books = new BooksRepository(mongoContext);
                return books;
            }
        }

        public IRepository<Service> Services
        {
            get
            {
                if (services == null)
                    services = new ServicesRepository(mongoContext);
                return services;
            }
        }

        public IRepository<Organization> Organizations
        {
            get
            {
                if (organizations == null)
                    organizations = new OrganizationsRepository(mongoContext);
                return organizations;
            }
        }

        public IRepository<Instance> Instances
        {
            get
            {
                if (instances == null)
                    instances = new InstanceRepository(mongoContext);
                return instances;
            }
        }

        public IRepository<Issue> Issues
        {
            get
            {
                if (issues == null)
                    issues = new IssuesRepository(mongoContext);
                return issues;
            }
        }

        public IRepository<Reader> Readers
        {
            get
            {
                if (readrs == null)
                    readrs = new ReadersRepository(mongoContext);
                return readrs;
            }
        }

    }
}
