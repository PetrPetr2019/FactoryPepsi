﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPepsi
{
    internal class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle Bottle()
        {
            return  new CocaColaBottle();
        }

        public override AbstractCover Cover()
        {
            return new CocaColaCover();
        }

        public override AbstractVolume Volume()
        {
            return  new ColaVolume();
        }

        public override AbstractWater Water()
        {
            return new CocaColaWater();
        }
    }

   
}
