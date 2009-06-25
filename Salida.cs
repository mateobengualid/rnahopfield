using System;
using System.Collections.Generic;
using System.Text;

namespace RNAHopfield.salida
{
    public abstract class Salida: Object 
    {
        public abstract double f(Neurona n);
    }
}
