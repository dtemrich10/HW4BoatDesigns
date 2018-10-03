using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class SailBoatBody : IBoatBody 
    {
        public virtual string BoatBodyStyle
        {
            get
            {
                return "This a Sail Boat Body style";
            }
        }
    }
}
