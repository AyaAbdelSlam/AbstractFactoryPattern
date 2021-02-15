using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildbeast();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
