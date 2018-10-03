using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;

namespace Builder
{
    class SailBoat : AbstractSailBoat 
    {
      
        public SailBoat (IBoatMotor engine, IBoatColor color, IBoatBody body)
            :base(engine, color, body)
        {

        }

        public override String ToString()
        {
            return "This is a Sailboat. and " + BoatColor.BoatColor + " and the engine is " + Engine.MotorSize  + " and " + Body.BoatBodyStyle;
        }
    }
}
