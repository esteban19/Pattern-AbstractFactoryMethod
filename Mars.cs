using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Mars : Planet
    {
        /* Created new instance as per instructions from Planet.cs*/
       PFMarsMountain mountain = new PFMarsMountain();

        private PlanetBuilding pb;
        public Mars(PlanetBuilding pb)
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
