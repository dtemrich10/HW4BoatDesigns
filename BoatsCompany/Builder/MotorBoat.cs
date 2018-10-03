using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;

namespace Builder
{
    public class MotorBoat : AbstractBoat
    {
        public MotorBoat(IBoatMotor engine, IBoatColor color, IBoatBody body)
         : base(engine, color, body)
        {

        }

    }
}
