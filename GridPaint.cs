using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RNAHopfield
{
    public partial class GridPaint : Control
    {
        bool isMousePressed = false;

        int cuadrosFila = 1;
        public int CuadrosFila
        {
            get { return cuadrosFila; }
            set { cuadrosFila = value;
            cuadritos = new int[cuadrosColumna, cuadrosFila];
            Refresh();
        }
        }

        int cuadrosColumna = 1;
        public int CuadrosColumna
        {
            get { return cuadrosColumna; }
            set { cuadrosColumna = value;
                  cuadritos = new int[cuadrosColumna, cuadrosFila];
                  Refresh();
            }
        }

        int[,] cuadritos;
        public int[,] Cuadritos
        {
            get { return cuadritos; }
            set { cuadritos = value; Refresh(); }
        }

        public GridPaint()
        {
            InitializeComponent();
        }

        public void limpiar()
        {
            for (int x = 0; x < cuadrosColumna; x++)
            {
                for (int y = 0; y < cuadrosFila; y++)
                {
                    cuadritos[x, y] = 0;
                }
            }  
            this.Refresh();     
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            isMousePressed = true;
        }

        protected override void  OnMouseMove(MouseEventArgs e)
        {
 	        base.OnMouseMove(e);

            if (isMousePressed)
            {
                mouseClicked(e);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            isMousePressed = false;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            mouseClicked(e);
        }

        private void mouseClicked(MouseEventArgs e)
        {
            decimal pasoX = (int)(this.Width / cuadrosColumna);
            decimal pasoY = (int)(this.Height / cuadrosFila);
            decimal x = e.X / pasoX;
            decimal y = e.Y / pasoY;

            int xd = (int)(Math.Truncate(x));
            int yd = (int)(Math.Truncate(y));

            try
            {
                //if (xd < cuadrosColumna && yd < cuadrosFila)
                //{
                //    cuadritos[xd, yd] = 1;
                //}

                // El siguiente pedazo de código de encarga de aumentar el tamaño de
                // pintado
                for (int h = -1; h < 1; h++)
                {
                    for (int k = -1; k < 1; k++)
                    {
                        if (-1 < xd + h && xd + h < cuadrosColumna && -1 < yd + k && yd + k < cuadrosFila)
                        {
                            cuadritos[xd + h, yd + k] = 1;
                        }
                    }
                }

            }
            catch (IndexOutOfRangeException ex)
            {
                // Nothing
            }
            finally
            {
                Refresh();
            }            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int pasoX = (int)(this.Width / cuadrosColumna);
            int pasoY = (int)(this.Height / cuadrosFila);

            for (int x = 0; x < cuadrosColumna; x++)
            {
                for (int y = 0; y < cuadrosFila; y++)
                {
                    if (cuadritos[x, y] > 0.5)
                        e.Graphics.FillRectangle(System.Drawing.Brushes.Black, x * pasoX, y * pasoY, pasoX - 1, pasoY - 1);
                    else e.Graphics.FillRectangle(System.Drawing.Brushes.WhiteSmoke, x * pasoX, y * pasoY, pasoX * (x + 1) - 1, pasoY * (y + 1) - 1);
                }
            }
        }
    }
}
