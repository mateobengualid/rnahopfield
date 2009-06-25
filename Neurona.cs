using System;
using System.Collections.Generic;
using System.Text;
using RNAHopfield.activacion;
using RNAHopfield.salida;

namespace RNAHopfield
{
    public class Neurona
    {
        String nombre;
        activacion.Activacion act;
        salida.Salida sal;
        
        double valorFuturo;

        double valorActual;
        public double ValorActual
        {
            get { return valorActual; }
            set { valorActual = value; }
        }

        //Estos enlaces son de llegada a la neurona, no de partida de esta!
        Neurona[] enlace;
        internal Neurona[] Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }

        double[] peso;
        public double[] Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        public Neurona(String nom)
        {
            sal = new SalidaSumatoria();
            act = new ActivacionEscalon(0);
            //act = new ActivacionHiperbolica();
            nombre = nom;
        }

        public void procesar()
        {
            valorFuturo = act.h(sal.f(this));
        }

        public void actualizar()
        {
            valorActual = valorFuturo;
        }

        //Se encarga de determinar si ya se estabilizó este valor
        public bool cumpleNorma()
        {
            return Math.Abs(valorActual - valorFuturo) < 0.01;
        }
    }
}
