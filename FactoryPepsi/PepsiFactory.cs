using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPepsi
{
    internal class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle Bottle()
        {
            return new PepsiBottle();
        }

        public override AbstractCover Cover()
        {
            return new PepsiCover();
        }
        public override AbstractVolume Volume()
        {
            return  new PepsiVolume();
        }

        public override AbstractWater Water()
        {
            return new PepsiWater();
        }
    }

}
