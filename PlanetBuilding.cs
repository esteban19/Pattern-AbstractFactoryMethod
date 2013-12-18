using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class PlanetBuilding
    {
        protected abstract Planet makeAPlanet(string option);

        public virtual Planet orderAPlanet(string option)
        {
            Planet thePlanet = makeAPlanet(option);
            return thePlanet;
        }
        
    }
}
