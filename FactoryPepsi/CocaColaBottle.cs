using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPepsi
{
    // Конкретный класс Bottle 1)
    internal class CocaColaBottle : AbstractBottle
    {
        public override void Bottle()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Bottle Coca-Cola");
        }
    }
}
