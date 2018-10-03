using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;

namespace BoatsCompany
{
    class Program
    {
        static void Main(string[] args)
        {
   //         MakeMeABoatAbstractFactoryPattern();
            MakeMeABoatBuilderPattern();
        }

        private static void MakeMeABoatBuilderPattern()
        {
            IBoatMotor bm = new SailBoatMotor();
            IBoatColor bc = new SailBoatColor("Blue", false);
            IBoatBody bb = new SailBoatBody();

            AbstractSailBoat boat = new SailBoat(bm, bc, bb);
            BoatBuilder builder = new SailBoatBuilder(boat);
            BoatDirector director = new SailBoatDirector();
            IBoat b = director.Build(builder);
            Console.WriteLine(b.ToString());
        }

        private static void MakeMeABoatAbstractFactoryPattern()
        {
            string whatToMake = "Sail Boat";
            AbstractBoatFactory factory = null;
            IBoatColor boatColor = null;

            if (whatToMake.Equals("Sail Boat"))
            {
                factory = new SailBoatFactory();
                boatColor = factory.CreateBoatColor("Blue", true);
            }
            else
            {
                factory = new MotorBoatFactory();
                boatColor = factory.CreateBoatColor("Green", false);
            }

            IBoatBody boatBody = factory.CreateBoatBody();
            IBoatMotor boatMotor = factory.CreateBoatMotor();

            //Show what was created
            Console.WriteLine(boatBody.BoatBodyStyle);
            Console.WriteLine(boatMotor.MotorSize);
            Console.WriteLine(boatColor.BoatColor );

        }
    }
}
