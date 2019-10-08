using System;

namespace FactoryPepsi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var client1 = new Client(new PepsiFactory());
            client1.Water();
            client1.Bottle();
            client1.Cover();
            client1.Volume();
            Console.WriteLine(new string('-', 15));
            var client2 = new Client(new CocaColaFactory());
            client2.Water();
            client2.Bottle();
            client2.Cover();
            client2.Volume();
            Console.ReadLine();
        }
    }
}


