using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class PhobosPlanetFactory : IPlanetFactory
    {
        public PFMountain addMountain()
        {
            return new PFPhobosMountain();//Specific to Mars,Phobos planets
        }
    }
}
