using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    public class TrainType
    {
        public int Name { get; }
        public bool HasToilets { get; }
        public bool HasBuffets { get; }
        public bool HasCargoCompartments { get; }

        public TrainType(int name, bool hasToilets, bool hasBuffets, bool hasCargoCompartments)
        {
            Name = name;
            HasToilets = hasToilets;
            HasBuffets = hasBuffets;
            HasCargoCompartments = hasCargoCompartments;
        }
    }
}
