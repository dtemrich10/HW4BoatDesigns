using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;

namespace Builder
{
    public class AbstractSailBoat : AbstractBoat
    {
        public AbstractSailBoat(IBoatMotor engine, IBoatColor color, IBoatBody body)
            : base(engine, color, body)
        {

        }
    }
}
