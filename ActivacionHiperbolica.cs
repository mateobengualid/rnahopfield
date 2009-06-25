using System;
using System.Collections.Generic;
using System.Text;

namespace RNAHopfield.activacion
{
    /// <summary>
    /// Proporciona una salida basada en el intervalo [-1;+1]
    /// </summary>

    public class ActivacionHiperbolica: Activacion
    {
        public override double h(double entrada)
        {
            return Math.Tanh(entrada);
        }
    }
}
