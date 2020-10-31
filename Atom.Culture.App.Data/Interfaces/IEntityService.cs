﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Interfaces
{
    public interface IEntityService<T>
    {
        T Get(string id);
        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
