using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SailBoatMotor : IBoatMotor 
    {
        public virtual string MotorSize
        {
            get
            {
                return "The Sail Boat has a small motor";
            }
        }
    }
}
