using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class PlanetBuildTesting
    {
        static void Main(string[] args)
        {
            PlanetBuilding makePlanet = new MarsPlanetBuilding();

            Planet theBoss = makePlanet.orderAPlanet("M");
            Console.WriteLine(theBoss + "\n");

            Planet theGrunt = makePlanet.orderAPlanet("P");
            Console.WriteLine(theGrunt + "\n");
        }
    }
}
