using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Phobos : Planet
    {
        /* Created new instance as per instructions from Planet.cs*/
        PFPhobosMountain mountain = new PFPhobosMountain();

        private PlanetBuilding pb;
        public Phobos(PlanetBuilding pb)
        {
            // TODO: Complete member initialization
            this.pb = pb;
        }

        public override void makePlanet()
        {
            Console.WriteLine("Making enemy ship(makePlanet) " + Name);
        }
        public override string ToString()
        {
            return "Making enemy ship(To String) " + Name + "\n Mountain: " + mountain;
        }
    }
}
