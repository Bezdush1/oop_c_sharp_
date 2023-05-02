using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    public class CargoTrainExpression:IExpression
    {
        public bool Interpret(Train train)
        {
            return train.Type.HasCargoCompartments;
        }
    }
}
