namespace ejercicio4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nota1 = new System.Windows.Forms.TextBox();
            this.nota2 = new System.Windows.Forms.TextBox();
            this.nota3 = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.promediototal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio #4: Promedio de Notas.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(230, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la nota #1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(230, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la nota #2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(230, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingrese la nota #3:";
            // 
            // nota1
            // 
            this.nota1.Location = new System.Drawing.Point(373, 69);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(84, 20);
            this.nota1.TabIndex = 4;
            // 
            // nota2
            // 
            this.nota2.Location = new System.Drawing.Point(373, 98);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(84, 20);
            this.nota2.TabIndex = 5;
            // 
            // nota3
            // 
            this.nota3.Location = new System.Drawing.Point(374, 127);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(83, 20);
            this.nota3.TabIndex = 6;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(475, 89);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(85, 35);
            this.calcular.TabIndex = 7;
            this.calcular.Text = "Calcular promedio";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(276, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "El promedio de notas es:";
            // 
            // promediototal
            // 
            this.promediototal.AutoSize = true;
            this.promediototal.Location = new System.Drawing.Point(449, 184);
            this.promediototal.Name = "promediototal";
            this.promediototal.Size = new System.Drawing.Size(13, 13);
            this.promediototal.TabIndex = 9;
            this.promediototal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label6.Location = new System.Drawing.Point(244, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "*(Advertencia: Usar comas (,) para el ingreso de notas al sistema).*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 240);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.promediototal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nota1;
        private System.Windows.Forms.TextBox nota2;
        private System.Windows.Forms.TextBox nota3;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label promediototal;
        private System.Windows.Forms.Label label6;
    }
}

