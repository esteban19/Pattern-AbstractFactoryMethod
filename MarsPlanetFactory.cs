using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class MarsPlanetFactory : IPlanetFactory
    {
        public PFMountain addMountain()
        {
            return new PFMarsMountain();//Specific to Mars,Phobos planets
        }
    }
}
