using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;

namespace Builder
{
    public abstract class AbstractBoat : IBoat
    {
        private IBoatMotor _engine;
        private IBoatColor _boatColor;
        private IBoatBody _body;

        public AbstractBoat(IBoatMotor engine, IBoatColor color, IBoatBody body)
        {
            _engine = engine;
            _boatColor = color;
            _body = body;
        }
        public virtual IBoatMotor Engine
        {
            get
            {
                return _engine;
            }
        }
        public virtual IBoatColor BoatColor
        {
            get
            {
                return _boatColor;
            }
        }
        public virtual IBoatBody Body
        {
            get
            {
                return _body;
            }
        }

    }
}
