using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder 
{
    class MotorBoatBuilder : BoatBuilder
    {
        private AbstractMotorBoat _boatInProgress;

        public MotorBoatBuilder(AbstractMotorBoat MotorBoat)
        {
            _boatInProgress = MotorBoat;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building the motor boat body");
        }

        public override void PaintBoat()
        {
            Console.WriteLine("Painting the motor boat");
        }

        public override void BuildEngine()
        {
            Console.WriteLine("Building the motor boat engine");
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
