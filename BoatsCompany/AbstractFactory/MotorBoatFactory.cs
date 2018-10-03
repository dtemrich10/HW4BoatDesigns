using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MotorBoatFactory : AbstractBoatFactory
    {
        public override IBoatBody CreateBoatBody()
        {
            return new MotorBoatBody();
        }

        public override IBoatColor CreateBoatColor(String color, bool multiColor)
        {
            return new MotorBoatColor(color, multiColor);
        }

        public override IBoatMotor CreateBoatMotor()
        {
            return new MotorBoatMotor();
        }
    }
}
