using System;
using System.Collections.Generic;
using System.Text;

namespace RNAHopfield
{
    public class RedHopfieldPI
    {
        Neurona[] neuronas;

        double energiaInicial;
        public double EnergiaInicial
        {
            get { return energiaInicial; }
        }

        double energiaFinal;
        public double EnergiaFinal
        {
            get { return energiaFinal; }
        }

        int iteraciones;
        public int Iteraciones
        {
            get { return iteraciones; }
        }

        // double[] es un vector de datos de entrada (de información) con el que se entrenará
        // e igual al número de vectores de información M
        // (double[])[] es un vector de entradas igual a la cantidad de neuronas N
        public void entrenar(double[][] vectoresInformacion)
        {
            int N = vectoresInformacion[0].Length;
            int M = vectoresInformacion.Length;

            int i, j;

            double[][] resultado = MatrixOperations.MultiplyBySameWithTransposeFirst(vectoresInformacion);
            resultado = MatrixOperations.MultiplyWithColumnsFirstRowsSecond(MatrixOperations.Invert(resultado), MatrixOperations.T(vectoresInformacion));
            resultado = MatrixOperations.MultiplyWithColumnsFirstRowsSecond(vectoresInformacion, resultado);

            //Carga la matriz de pesos para que sea simétrica y contenga los productos buscados
            for (i = 0; i < N; i++)
            {
                //De esta forma nos aseguramos que no entrará en la diagonal
                for (j = i + 1; j < N; j++)
                {
                    neuronas[i].Peso[j - 1] = resultado[i][j];
                    neuronas[j].Peso[i] = resultado[j][i];
                }
            }
        }

        public RedHopfieldPI(double[][] vectoresInformacion)
        {
            int N = vectoresInformacion[0].Length;

            InicializarMatrizDeNeuronas(N);

            // Entrena la red neuronal
            entrenar(vectoresInformacion);
        }

        private void InicializarMatrizDeNeuronas(int N)
        {
            int i, j;

            // Crea una red de tamaño n, basado en el tamaño de la información
            // a memorizar            
            neuronas = new Neurona[N];

            // Crea las neuronas de la red con sus enlaces y pesos
            for (i = 0; i < N; i++)
            {
                neuronas[i] = new Neurona("Neurona " + (i + 1));
                neuronas[i].Peso = new double[N - 1];
                neuronas[i].Enlace = new Neurona[N - 1];
            }

            // Engancha los enlaces entre neuronas.
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < i; j++)
                {
                    neuronas[i].Enlace[j] = neuronas[j];
                }
                for (j = i + 1; j < N; j++)
                {
                    neuronas[i].Enlace[j - 1] = neuronas[j];
                }
            }
        }

        // Recibe un vector de entradas y produce salida cuando la variación de los pesos cumpla
        // la norma cúbica (cuando todos sean menores a un épsilon)
        public double[] calcular(double[] vectorEntrada)
        {
            int i, j;
            bool cumpleNorma;

            // Por lo pronto, que no calcule energia.
            //energiaInicial = calcularEnergia(vectorEntrada);

            for (i = 0; i < neuronas.Length; i++)
            {
                neuronas[i].ValorActual = vectorEntrada[i];
            }

            #region Inicializacion del Exportador
            // El siguiente pedazo de código inicializa el archivo
            //ExportadorHelper exportador = new ExportadorHelper("CALCULAR");
            #endregion

            j = 0;
            do
            {
                //System.Console.WriteLine("Vuelta " + j + ":");
                j++;

                cumpleNorma = true;

                for (i = 0; i < neuronas.Length; i++)
                {
                    //System.Console.WriteLine("" + neuronas[i].ValorActual);

                    neuronas[i].procesar();
                    cumpleNorma = cumpleNorma && neuronas[i].cumpleNorma();

                    // La siguiente instrucción actualiza el valor presente de la
                    // neurona, de modo que los valores que se calculen para las
                    // neuronas restantes tendrán valores distintos según el órden
                    // de cálculo.

                    neuronas[i].actualizar();

                    // Para exportar, queda ver con Juan Carlos Vazquez qué poner
                    // en cada parámetro. Por lo pronto, lo exporta para cada vuelta
                    // y no para cada neurona, que deberia ir a continuacion    

                    // Aqui Impresion de la red entera                    
                    //#region Impresion de la red entera
                    //for (int h = 0; h < neuronas.Length; h++)
                    //{
                    //                     etapa  juego  capa  neurona  peso                              valor actual 
                    //    exportador.write(    j,     i,    0,       h,    0, Convert.ToInt16(neuronas[h].ValorActual));
                    //}
                    //#endregion
                }

                // El siguiente ciclo permite actualizar la red entera, de forma
                // tal que primero se calculan los valores futuros para todas las
                // neuronas para sus valores actuales y luego cambiar todos de una
                // sola vez. En este caso, no se eligió esa metodología.
                //for (i = 0; i < neuronas.Length; i++)
                //{
                //    neuronas[i].actualizar();
                //}

                // Para exportar, queda ver con Juan Carlos Vazquez qué poner
                // en cada parámetro. Por lo pronto, lo exporta para cada vuelta,
                // que deberia ir a continuacion   
                #region Impresion de la red entera
                //for (int h = 0; h < neuronas.Length; h++)
                //{
                //                   //etapa  juego  capa  neurona  peso                              valor actual 
                //    exportador.write(    j,     i,    0,       h,    0, Convert.ToInt16(neuronas[h].ValorActual));
                //}
                #endregion


                //System.Console.WriteLine();
            }
            while ((!cumpleNorma) && (j < neuronas.Length * 10));

            //System.Console.WriteLine("Salida:");
            //for (i = 0; i < neuronas.Length; i++)
            //{
            //    System.Console.WriteLine(neuronas[i].ValorActual);
            //}

            // Construir el vector de retorno.
            double[] res = new double[neuronas.Length];
            for (i = 0; i < neuronas.Length; i++)
            {
                res[i] = neuronas[i].ValorActual;
            }

            // Asignar la variable j a la salida de iteraciones.
            iteraciones = j;

            // Por lo pronto, que no calcule energia.
            //energiaFinal = calcularEnergia(res);

            #region Destrucción del Exportador
            // El siguiente pedazo de código cierra el archivo
            //exportador.close();
            #endregion

            return res;
        }

        protected double calcularEnergia(double[] vectorActual)
        {
            double resultado = 0;
            int i, j;

            for (i = 0; i < neuronas.Length; i++)
            {
                for (j = 0; j < i; j++)
                {
                    resultado += neuronas[i].Peso[j] * vectorActual[i] * vectorActual[j];
                }
                for (j = i + 1; j < neuronas.Length; j++)
                {
                    resultado += neuronas[i].Peso[j - 1] * vectorActual[i] * vectorActual[j];
                }
            }

            return ((-0.5f) * resultado);
        }
    }
}
