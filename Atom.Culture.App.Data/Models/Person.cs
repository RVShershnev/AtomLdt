using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Models
{
    public class Person
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string BirthDate { get; set; }
        public List<Book> Books { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
