using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Abstraction;

namespace AbstractFactory.Implementation
{
    public class CocaColaFactory : Abstraction.AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }
    }
}
