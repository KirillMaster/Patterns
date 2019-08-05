using AbstractFactory.Abstraction;

namespace AbstractFactory.Implementation
{
    public class PepsiFactory : Abstraction.AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
           return new PepsiBottle();
        }

        public override AbstractWater CreateWater()
        {
           return new PepsiWater();
        }
    }
}
