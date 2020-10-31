using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.App.Data.Models
{
    public class Issue
    {
        public ObjectId Id { get; set; }
        public string IssueId { get; set; }
        public string ReaderIs { get; set; }
        public string InventoryNumber { get; set; }
        public string BarCode { get; set; }
        public string IssueDate { get; set; }
        public string ReturnDate { get; set; }
        public string Condition { get; set; }
        public string Unnamed { get; set; }
        public string Conditions { get; set; }
        public string UnnamedTwo { get; set; }
    }
}
