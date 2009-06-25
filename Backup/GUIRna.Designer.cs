namespace RNAHopfield.graphics
{
    partial class GUIRna
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEnergiaInicial = new System.Windows.Forms.Label();
            this.lblEnergiaFinal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.txtEnergiaInicial = new System.Windows.Forms.Label();
            this.txtEnergiaFinal = new System.Windows.Forms.Label();
            this.grillaOrigen = new RNAHopfield.GridPaint();
            this.grillaDestino = new RNAHopfield.GridPaint();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(434, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aprender letra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(4, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(434, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Intentar lectura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblEnergiaInicial);
            this.panel1.Controls.Add(this.lblEnergiaFinal);
            this.panel1.Controls.Add(this.grillaOrigen);
            this.panel1.Controls.Add(this.grillaDestino);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 299);
            this.panel1.TabIndex = 5;
            // 
            // lblEnergiaInicial
            // 
            this.lblEnergiaInicial.AutoSize = true;
            this.lblEnergiaInicial.Location = new System.Drawing.Point(3, 271);
            this.lblEnergiaInicial.Name = "lblEnergiaInicial";
            this.lblEnergiaInicial.Size = new System.Drawing.Size(73, 13);
            this.lblEnergiaInicial.TabIndex = 7;
            this.lblEnergiaInicial.Text = "Energia Inicial";
            // 
            // lblEnergiaFinal
            // 
            this.lblEnergiaFinal.AutoSize = true;
            this.lblEnergiaFinal.Location = new System.Drawing.Point(272, 271);
            this.lblEnergiaFinal.Name = "lblEnergiaFinal";
            this.lblEnergiaFinal.Size = new System.Drawing.Size(68, 13);
            this.lblEnergiaFinal.TabIndex = 8;
            this.lblEnergiaFinal.Text = "Energia Final";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(12, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 86);
            this.panel2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(4, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(434, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Limpiar Grilla";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtEnergiaInicial
            // 
            this.txtEnergiaInicial.AutoSize = true;
            this.txtEnergiaInicial.Location = new System.Drawing.Point(0, 316);
            this.txtEnergiaInicial.Name = "txtEnergiaInicial";
            this.txtEnergiaInicial.Size = new System.Drawing.Size(73, 13);
            this.txtEnergiaInicial.TabIndex = 7;
            this.txtEnergiaInicial.Text = "Energia Inicial";
            // 
            // txtEnergiaFinal
            // 
            this.txtEnergiaFinal.AutoSize = true;
            this.txtEnergiaFinal.Location = new System.Drawing.Point(249, 316);
            this.txtEnergiaFinal.Name = "txtEnergiaFinal";
            this.txtEnergiaFinal.Size = new System.Drawing.Size(68, 13);
            this.txtEnergiaFinal.TabIndex = 8;
            this.txtEnergiaFinal.Text = "Energia Final";
            // 
            // grillaOrigen
            // 
            this.grillaOrigen.CuadrosColumna = 63;
            this.grillaOrigen.CuadrosFila = 96;
            this.grillaOrigen.Location = new System.Drawing.Point(3, 3);
            this.grillaOrigen.Name = "grillaOrigen";
            this.grillaOrigen.Size = new System.Drawing.Size(126, 192);
            this.grillaOrigen.TabIndex = 1;
            // 
            // grillaDestino
            // 
            this.grillaDestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaDestino.CuadrosColumna = 63;
            this.grillaDestino.CuadrosFila = 96;
            this.grillaDestino.Location = new System.Drawing.Point(274, 3);
            this.grillaDestino.Name = "grillaDestino";
            this.grillaDestino.Size = new System.Drawing.Size(126, 192);
            this.grillaDestino.TabIndex = 2;
            // 
            // GUIRna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 412);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GUIRna";
            this.Text = "GUIRna";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private GridPaint grillaOrigen;
        private GridPaint grillaDestino;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblEnergiaInicial;
        private System.Windows.Forms.Label lblEnergiaFinal;
        private System.Windows.Forms.Label txtEnergiaInicial;
        private System.Windows.Forms.Label txtEnergiaFinal;
    }
}