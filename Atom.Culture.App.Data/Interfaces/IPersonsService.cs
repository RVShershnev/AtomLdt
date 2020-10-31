using Atom.Culture.App.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Interfaces
{
    public interface IPersonsService
    {
        Person Get(string id);
    }
}
