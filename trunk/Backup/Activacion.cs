using System;
using System.Collections.Generic;
using System.Text;

namespace RNAHopfield.activacion
{
    public abstract class Activacion
    {
        protected double umbral;

        public double Umbral
        {
            get { return umbral; }
            set { umbral = value; }
        }

        public abstract double h(double entrada);
    }
}
