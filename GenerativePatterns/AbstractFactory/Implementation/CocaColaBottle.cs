using AbstractFactory.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Implementation
{
    public class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }
    }
}
