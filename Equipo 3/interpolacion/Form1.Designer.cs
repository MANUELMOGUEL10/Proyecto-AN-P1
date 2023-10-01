namespace interpolacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbPuntos = new System.Windows.Forms.TextBox();
            this.tbValorInterpolar = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInterpolar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPuntos
            // 
            this.tbPuntos.Location = new System.Drawing.Point(214, 104);
            this.tbPuntos.Name = "tbPuntos";
            this.tbPuntos.Size = new System.Drawing.Size(100, 26);
            this.tbPuntos.TabIndex = 0;
            // 
            // tbValorInterpolar
            // 
            this.tbValorInterpolar.Location = new System.Drawing.Point(214, 178);
            this.tbValorInterpolar.Name = "tbValorInterpolar";
            this.tbValorInterpolar.Size = new System.Drawing.Size(100, 26);
            this.tbValorInterpolar.TabIndex = 1;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(214, 247);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(100, 26);
            this.tbResultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "INTERPOLACION.";
            // 
            // btnInterpolar
            // 
            this.btnInterpolar.Location = new System.Drawing.Point(375, 164);
            this.btnInterpolar.Name = "btnInterpolar";
            this.btnInterpolar.Size = new System.Drawing.Size(129, 55);
            this.btnInterpolar.TabIndex = 4;
            this.btnInterpolar.Text = "INTERPOLAR";
            this.btnInterpolar.UseVisualStyleBackColor = true;
            this.btnInterpolar.Click += new System.EventHandler(this.btnInterpolar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coordenadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor conocido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInterpolar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbValorInterpolar);
            this.Controls.Add(this.tbPuntos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPuntos;
        private System.Windows.Forms.TextBox tbValorInterpolar;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInterpolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

