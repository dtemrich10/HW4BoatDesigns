using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class BoatDirector
    {
        public abstract IBoat Build(BoatBuilder buider);
    }
}
