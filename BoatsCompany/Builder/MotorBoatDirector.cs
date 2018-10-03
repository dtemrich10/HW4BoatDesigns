using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MotorBoatDirector : BoatDirector
    {
        public override IBoat Build(BoatBuilder builder)
        {
            builder.BuildBody();
            builder.BuildEngine();
            builder.PaintBoat();
            return builder.Boat;
        }
    }
}
