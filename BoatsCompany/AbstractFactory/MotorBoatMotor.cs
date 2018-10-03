using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MotorBoatMotor : IBoatMotor
    {
        public virtual string MotorSize
        {
            get
            {
                return "This Motor Boat has a powerful motor";
            }
        }
    }
}
