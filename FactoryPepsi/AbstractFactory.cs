using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPepsi
{
    // Абстрактные  фабрикаи напитков 
    internal abstract class AbstractFactory
    {
        public abstract AbstractWater Water();
        public abstract AbstractBottle Bottle();
        public abstract AbstractCover Cover();
        public abstract AbstractVolume Volume();
    }
}
