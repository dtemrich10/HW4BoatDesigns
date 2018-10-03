using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AbstractBoatFactory
    {
        public abstract IBoatBody CreateBoatBody();
        public abstract IBoatMotor CreateBoatMotor();
        public abstract IBoatColor CreateBoatColor(string color, bool multiColor);
    }
}
