using System;
using System.Collections.Generic;

namespace Atom.Culture.App.Data.Models
{
    public class Participiant
    {
        public string Id { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public List<Service> Services { get; set; }
        public List<Recomendation> Recomendations { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
