using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RNAHopfield.graphics;

namespace RNAHopfield
{
    static class Program
    {
        /*static void Main()
        {
            //Tres vectores de entrenamiento, cuatro neuronas
            double[][] red = new double[3][];

            // Carga vector de información
            red[0] = new double[8];
            red[0][0]  = -1;  
            red[0][1]  = -1; 
            red[0][2] = +1;
            red[0][3]  = -1; 
            red[0][4]  = -1;
            red[0][5]  = +1;  
            red[0][6]  = -1; 
            red[0][7]  = -1;        
            
            // Carga vector de información
            red[1] = new double[8];
            red[1][0] = -1;
            red[1][1] = -1;
            red[1][2] = -1;
            red[1][3] = 1;
            red[1][4] = 1;
            red[1][5] = 1;
            red[1][6] = 1;
            red[1][7] = -1;

            // Carga vector de información
            red[2] = new double[8];
            red[2][0] = 1;
            red[2][1] = -1;
            red[2][2] = -1;
            red[2][3] = 1;
            red[2][4] = 1;
            red[2][5] = -1;
            red[2][6] = -1;
            red[2][7] = 1;

            RedHopfieldPI rH = new RedHopfieldPI();
            rH.generarRed(red);

            double[] entrada = new double[8];
            entrada[0] = -1;
            entrada[1] = -1;
            entrada[2] = 1;
            entrada[3] = 1;
            entrada[4] = 1;
            entrada[5] = 1;
            entrada[6] = 1;
            entrada[7] = -1;

            rH.calcular(entrada);
       }*/

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUIRna());
        }
    }
}