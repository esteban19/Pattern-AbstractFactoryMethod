using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class MarsPlanetBuilding : PlanetBuilding
    {
        protected override Planet makeAPlanet(string option)
        {
            Planet newPlanet = null;

            if (option == "M")
            {
                PlanetBuilding pb = new MarsPlanetBuilding();
                newPlanet = new Mars(pb);
                newPlanet.Name = "Hi I'm Mars";
                newPlanet.makePlanet();
            }
            else if (option == "P")
            {
                PlanetBuilding pb = new MarsPlanetBuilding();
                newPlanet = new Phobos(pb);
                newPlanet.Name = "Hi I'm Phobos";
                newPlanet.makePlanet();
            }
            return newPlanet;
        }
    }
}
