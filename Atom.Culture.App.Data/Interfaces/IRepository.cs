using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T item);
        void Update(T item);
        void Delete(T item);
        IEnumerable<T> GetAll();
        T Get(string id);
    }
}
