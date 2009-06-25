using System;
using System.Collections.Generic;
using System.Text;

namespace RNAHopfield.activacion
{
    public class ActivacionEscalon: Activacion
    {
        public ActivacionEscalon(double umbral)
        {
            this.umbral = umbral;
        }

        public override double h(double entrada)
        {
            if (umbral < entrada)
                {return 1;}
            else 
                {return -1;}
        }
    }
}
