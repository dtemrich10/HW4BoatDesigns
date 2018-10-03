using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MotorBoatColor : IBoatColor
    {
        private bool _isMultiColor = false;
        private string _boatColor;

        public virtual bool isMultiColor
        {
            get { return _isMultiColor; }
            set { _isMultiColor = value; }
        }

        public virtual string BoatColor
        {
            set { _boatColor = value; }
            get
            {
                if (isMultiColor)
                {
                    return "This is a multicolor " + _boatColor + " Motor Boat";
                }
                else
                {
                    return "This is a " + _boatColor + " Motor Boat";
                }
            }
        }

        public MotorBoatColor(string color, bool ismulticolor)
        {
            this._boatColor = color;
            this._isMultiColor = ismulticolor;
        }
    }
}
