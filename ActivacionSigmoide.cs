using System;
using System.Collections.Generic;
using System.Text;

namespace RNAHopfield.activacion
{
    /// <summary>
    /// /// Proporciona una salida basada en el intervalo [0;+1]
    /// </summary>
    public class ActivacionSigmoide: Activacion
    {
        public override double h(double entrada)
        {
            return (1/(1+Math.Exp(-entrada)));
        }
    }
}
