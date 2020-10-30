using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom.Culture.App.Shared
{
    [Serializable]
    public class PersonalInformation
    {
        public string FullName { get; set; }
        public byte[] Photo { get; set; }
        public DateTime DateBithday { get; set; }
    }
}
