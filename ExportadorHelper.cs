using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace RNAHopfield
{
    class ExportadorHelper
    {
        TextWriter tw;

        public ExportadorHelper(String fileName)
        {
            tw = File.CreateText(".\\" + fileName + DateTime.Now.ToString().Replace(':', '_').Replace(' ', '_').Replace('/', '_') + ".TXT");
            tw.WriteLine("# Arquitectura de la Red: HOPFIELD ############");
            tw.WriteLine("   1 Número de juegos de entrenamiento         ");
            tw.WriteLine("   1 Número de capas                           ");
            tw.WriteLine(" 600 Número de neuronas de la capa    1        ");
            tw.WriteLine("###############################################");
            tw.WriteLine("#NroEtapa:Juego:Capa:Neurona:Peso:ValorNeurona:");
        }

        public void write(int etapa, int juego, int capa, int neurona, int peso, int valorNeurona)
        {
            // Se realizan los saltos de linea para dejar en posición adecuada            
            tw.Write(String.Format("{0,-9}", etapa));
            tw.Write(String.Format("{0,-6}", juego));
            tw.Write(String.Format("{0,-5}", capa));
            tw.Write(String.Format("{0,-8}", neurona));
            tw.Write(String.Format("{0,-5}", peso));
            tw.WriteLine(String.Format("{0,-13}", valorNeurona));
        }

        public void close()
        {
            tw.Close();
        }
    }
}
