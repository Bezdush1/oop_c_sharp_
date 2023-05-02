using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_7
{
    public class TrainStationInterpreter
    {
        private readonly List<IExpression> _expressions;

        public TrainStationInterpreter(List<IExpression> expressions)
        {
            _expressions = expressions;
        }

        public string Interpret(Train train)
        {
            foreach (var expression in _expressions)
            {
                if (expression.Interpret(train))
                {
                    return "YES";
                }
            }

            return "NO";
        }

        public string GetTrainType(Train train)
        {
            if (train.Type.HasCargoCompartments &&
               train.Type.HasToilets &&
               train.Type.HasBuffets)
            {
                return "Супер-навороченный вагон";
            }
            else if (train.Type.HasBuffets && 
                train.Type.HasToilets &&
                !train.Type.HasCargoCompartments) 
            {
                return "Пассажирский вагон";
            }
            else if(!train.Type.HasBuffets &&
                !train.Type.HasToilets &&
                train.Type.HasCargoCompartments)
            {
                return "Грузовой вагон";
            }
            else if (train.Type.HasBuffets &&
                !train.Type.HasToilets &&
                !train.Type.HasCargoCompartments)
            {
                return "Вагон-ресторан";
            }
            else if (train.Type.HasToilets &&
                !train.Type.HasBuffets &&
                !train.Type.HasCargoCompartments)
            {
                return "Вагон-туалет";
            }
            else 
            { 
                return "неизвестный тип вагона"; 
            }
        }
    }
}
