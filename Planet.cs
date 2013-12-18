using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public abstract class Planet
    {
        private PFMountain mountain;

        private string name;
        public Planet() { }
        public Planet(string n)
        {
            Name = n;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //public abstract void setName(string newName);
        public abstract void makePlanet();
        public abstract override string ToString();
    }
}
