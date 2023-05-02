using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    public class Train
    {
        public int Number { get; }
        public TrainType Type { get; }

        public Train(int number, TrainType type)
        {
            Number = number;
            Type = type;
        }
    }
}
