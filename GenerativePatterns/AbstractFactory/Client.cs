using AbstractFactory.Abstraction;


namespace AbstractFactory
{
    public class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;

        public Client(Abstraction.AbstractFactory factory)
        {
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
        }

        public void Run()
        {
            bottle.Interact(water);
        }
    }
}
