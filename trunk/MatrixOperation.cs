using System;
using System.Collections.Generic;
using System.Text;

namespace RNAHopfield
{
    public static class MatrixOperations
    {
        public static double[][] MultiplyBySameWithTransposeFirst(double[][] matrix)
        {
            int length = matrix.Length;

            double[][] result = new double[length][];
            double sum;

            for (int i = 0; i < matrix.Length; i++)
            {
                result[i] = new double[length];

                for (int j = 0; j < matrix.Length; j++)
                {
                    sum = 0;

                    for (int k = 0; k < matrix[0].Length; k++)
                    {
                        sum += matrix[j][k] * matrix[i][k];
                    }

                    result[i][j] = sum;
                }
            }

            return result;
        }

        public static double[][] Sum(double[][] a, double[][] b)
        {
            double[][] result = new double[a.Length][];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = new double[b.Length];

                for (int j = 0; j < b[0].Length; j++)
                {
                    result[i][j] = a[i][j] + b[i][j];
                }
            }

            return result;
        }

        public static double[][] Multiply(double k, double[][] b)
        {
            double[][] result = new double[b.Length][];

            for (int i = 0; i < b.Length; i++)
            {
                result[i] = new double[b.Length];

                for (int j = 0; j < b[0].Length; j++)
                {
                    result[i][j] = k * b[i][j];
                }
            }

            return result;
        }

        public static double[][] Multiply(double[][] b, double k)
        {
            return Multiply(k, b);
        }

        public static double[][] MultiplyWithColumnsFirstRowsSecond(double[][] a, double[][] b)
        {
            if (a.Length == b[0].Length)
            {
                double[][] result = new double[b.Length][];

                for (int j = 0; j < b.Length; j++)
                {
                    result[j] = new double[a[0].Length];

                    for (int i = 0; i < a[0].Length; i++)
                    {
                        result[j][i] = 0;

                        for (int k = 0; k < a.Length; k++)
                        {
                            result[j][i] += a[k][i] * b[j][k];
                        }
                    }
                }

                return result;
            }
            else
            {
                throw new Exception("Bad matrices.");
            }
        }

        public static double[][] MultiplyWithRowsFirstColumnsSecond(double[][] a, double[][] b)
        {
            if (a[0].Length == b.Length)
            {
                double[][] result = new double[a.Length][];

                for (int i = 0; i < a.Length; i++)
                {
                    result[i] = new double[b[0].Length];
                    for (int j = 0; j < b[0].Length; j++)
                    {
                        result[i][j] = 0;

                        for (int k = 0; k < a.Length; k++)
                        {
                            result[i][j] += a[i][k] * b[k][j];
                        }
                    }
                }

                return result;
            }
            else
            {
                throw new Exception("Bad matrices.");
            }
        }

        public static double[][] T(double[][] b)
        {
            double[][] result = new double[b[0].Length][];

            for (int i = 0; i < b[0].Length; i++)
            {
                result[i] = new double[b.Length];

                for (int j = 0; j < b.Length; j++)
                {
                    result[i][j] = b[j][i];
                }
            }

            return result;
        }

        public static double[][] Identity(int size)
        {
            double[][] result = new double[size][];

            for (int i = 0; i < size; i++)
            {
                result[i] = new double[size];

                for (int j = 0; j < size; j++)
                {
                    result[i][j] = (i == j ? 1 : 0);
                }
            }

            return result;
        }

        public static double[][] Invert(double[][] a)
        {
            double[][] workMatrix = new double[a.Length][];
            double[][] result = new double[a.Length][];

            // Arma la matriz combinada.
            for (int i = 0; i < a.Length; i++)
            {
                workMatrix[i] = new double[a.Length * 2];

                for (int j = 0; j < a[0].Length; j++)
                {
                    workMatrix[i][j] = a[i][j];
                    workMatrix[i][j + a.Length] = i == j ? 1 : 0;
                }
            }

            // Resuelve por Gauss Jordan.
            for (int i = 0; i < a.Length; i++)
            {
                // Regla 1.
                for (int k = i + 1; k < a[0].Length * 2; k++)
                {
                    workMatrix[i][k] /= workMatrix[i][i];
                }

                // Regla 2.
                for (int k = 0; k < a.Length; k++)
                {

                    // Hop over if k==i
                    if (k != i)
                    {
                        for (int j = i + 1; j < a[0].Length * 2; j++)
                        {
                            workMatrix[k][j] -= workMatrix[k][i] * workMatrix[i][j];
                        }
                    }
                }
            }

            // Recorta la matriz y la manda.
            for (int i = 0; i < a[0].Length; i++)
            {
                result[i] = new double[a[0].Length];
                Array.Copy(workMatrix[i], a.Length, result[i], 0, a.Length);
            }

            return result;
        }
    }
}
