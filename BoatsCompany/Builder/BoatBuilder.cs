using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class BoatBuilder
    {
        public virtual void BuildBody() { }
        public virtual void PaintBoat() { }
        public virtual void BuildEngine() { }

        public abstract IBoat Boat { get; }
    }
}
