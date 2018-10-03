using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SailBoatFactory : AbstractBoatFactory
    {
        public override IBoatBody CreateBoatBody()
        {
            return new SailBoatBody();
        }

        public override IBoatColor CreateBoatColor(string color, bool isMultiColor)
        {
            return new SailBoatColor(color, isMultiColor);
        }

        public override IBoatMotor CreateBoatMotor()
        {
            return new SailBoatMotor();
        }
    }
}
