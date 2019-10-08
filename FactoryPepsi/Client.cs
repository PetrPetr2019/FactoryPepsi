using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPepsi
{
    internal class Client
    {
        private readonly AbstractWater water;
        private readonly AbstractBottle bottle;
        private readonly AbstractCover cover;
        private readonly AbstractVolume volume;

        // Конструктор
        public Client(AbstractFactory factory)
        {
            water = factory.Water();
            bottle = factory.Bottle();
            cover = factory.Cover();
            volume = factory.Volume();
        }

        public void Water()
        {
            water.Water();
        }

        public void Bottle()
        {
            bottle.Bottle();
        }

        public void Cover()
        {
            cover.Cover();
        }

        public void Volume()
        {
           volume.Volume();
        }
    }
}
