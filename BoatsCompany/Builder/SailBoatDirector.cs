using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class SailBoatDirector : BoatDirector
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
