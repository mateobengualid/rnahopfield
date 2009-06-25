using System;
using System.Collections.Generic;
using System.Text;
using RNAHopfield.salida;

namespace RNAHopfield.salida
{
    public class SalidaSumatoria: Salida
    {
        public override double f(Neurona n)
        {
            double aux = 0;
            for(int i = 0; i< n.Peso.Length;i++)
            {
                aux += n.Peso[i] * n.Enlace[i].ValorActual;
            }
            return aux;
        }
    }
}
