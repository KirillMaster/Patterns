using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Client
    {
        public void Run()
        {
            Circle figure = new Circle(30, 50, 60);

            // применяем глубокое копирование
            Circle clonedFigure = figure.DeepCopy() as Circle;
            figure.Point.X = 100;
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }
}
