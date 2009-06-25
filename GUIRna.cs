using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RNAHopfield.graphics
{
    public partial class GUIRna : Form
    {
        RedHopfield rH = new RedHopfield(150);
        double[][] vectInf = new double[1][];

        public GUIRna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] cuadritos = new double[grillaOrigen.CuadrosColumna *
                                      grillaOrigen.CuadrosFila];

            for (int i = 0; i < grillaOrigen.CuadrosColumna; i++)
            {
                for (int j = 0; j < grillaOrigen.CuadrosFila; j++)
                {
                    cuadritos[j*grillaOrigen.CuadrosColumna+i]=grillaOrigen.Cuadritos[i,j]*2-1;
                }
            }
            
            vectInf[0] = cuadritos;
            rH.entrenar(vectInf);            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] cuadritos = new double[grillaOrigen.CuadrosColumna *
                                      grillaOrigen.CuadrosFila];         

            int[,] matriz = grillaOrigen.Cuadritos;

            for (int i = 0; i < grillaOrigen.CuadrosColumna; i++)
            {
                for (int j = 0; j < grillaOrigen.CuadrosFila; j++)
                {
                    cuadritos[j * grillaOrigen.CuadrosColumna + i] = (matriz[i, j])*2-1;
                }
            }

            cuadritos = rH.calcular(cuadritos);

            // Por lo pronto, que no muestre energia.
            //lblEnergiaInicial.Text = "Energía Inicial: " + rH.EnergiaInicial;
            //lblEnergiaFinal.Text = "Energía Final: " + rH.EnergiaFinal;

            matriz = new int[grillaOrigen.CuadrosColumna, grillaOrigen.CuadrosFila];

            for (int i = 0; i < grillaOrigen.CuadrosColumna; i++)
            {
                for (int j = 0; j < grillaOrigen.CuadrosFila; j++)
                {
                    matriz[i, j] = (int)(cuadritos[j * grillaOrigen.CuadrosColumna + i]/2+0.5);
                }
            }

            grillaDestino.Cuadritos = matriz;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grillaOrigen.limpiar();
        }
    }
}