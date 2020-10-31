using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom.Culture.App.Shared
{
    public interface IExperiencable
    {
        public List<IRecomendation> Experience { get; set; }    
    }
}
