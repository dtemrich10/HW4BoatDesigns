using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SailBoatBuilder : BoatBuilder
    {
        private AbstractSailBoat _boatInProgress;

        public SailBoatBuilder(AbstractSailBoat SailBoat)
        {
            _boatInProgress = SailBoat;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building the sail boat body");
        }

        public override void PaintBoat()
        {
            Console.WriteLine("Painting the sail boat");
        }

        public override void BuildEngine()
        {
            Console.WriteLine("Building the sail boat engine");
        }

        public override IBoat Boat
        {
            get
            {
                return _boatInProgress;
            }
        }

    }
}
