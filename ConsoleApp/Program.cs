using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Implementation;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunAbstractFactorySample();
            //RunBuilderSample();
            //RunFactoryMethodSample();
            RunPrototypeSample();

            Console.ReadKey();
        }


        public static void RunAbstractFactorySample()
        {
            AbstractFactory.Client client = new AbstractFactory.Client(new PepsiFactory());

            client.Run();
        }

        public static void RunBuilderSample()
        {
            Builder.Client client = new Builder.Client();
            client.Run();
        }

        public static void RunFactoryMethodSample()
        {
            FactoryMethod.Client client = new FactoryMethod.Client();
            client.Run();
        }

        public static void RunPrototypeSample()
        {
            new Prototype.Client().Run();
        }
    }
}
