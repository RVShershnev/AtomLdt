using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom.Culture.App.Shared
{
    public interface IRecomendation
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        

    }
}
