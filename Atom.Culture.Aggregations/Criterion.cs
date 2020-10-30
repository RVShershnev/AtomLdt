using Consonance.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atom.Culture.Aggregations
{
    public class Criterion : ICriterion
    {
        public CriterionOrientation Orientation { get; set; }

        public dynamic GetValue(dynamic x)
        {
            throw new NotImplementedException();
        }
    }
}
