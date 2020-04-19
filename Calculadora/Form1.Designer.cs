namespace Calculadora
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
            this.buttonMultiplos = new System.Windows.Forms.Button();
            this.buttonDivisores = new System.Windows.Forms.Button();
            this.buttonSerie = new System.Windows.Forms.Button();
            this.buttonFibonacci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.TextBox();
            this.salida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5Factorial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMultiplos
            // 
            this.buttonMultiplos.Location = new System.Drawing.Point(66, 72);
            this.buttonMultiplos.Name = "buttonMultiplos";
            this.buttonMultiplos.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplos.TabIndex = 0;
            this.buttonMultiplos.Text = "Multiplos";
            this.buttonMultiplos.UseVisualStyleBackColor = true;
            this.buttonMultiplos.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDivisores
            // 
            this.buttonDivisores.Location = new System.Drawing.Point(147, 72);
            this.buttonDivisores.Name = "buttonDivisores";
            this.buttonDivisores.Size = new System.Drawing.Size(75, 23);
            this.buttonDivisores.TabIndex = 1;
            this.buttonDivisores.Text = "Divisores";
            this.buttonDivisores.UseVisualStyleBackColor = true;
            this.buttonDivisores.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSerie
            // 
            this.buttonSerie.Location = new System.Drawing.Point(66, 113);
            this.buttonSerie.Name = "buttonSerie";
            this.buttonSerie.Size = new System.Drawing.Size(75, 23);
            this.buttonSerie.TabIndex = 2;
            this.buttonSerie.Text = "Serie";
            this.buttonSerie.UseVisualStyleBackColor = true;
            this.buttonSerie.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonFibonacci
            // 
            this.buttonFibonacci.Location = new System.Drawing.Point(147, 113);
            this.buttonFibonacci.Name = "buttonFibonacci";
            this.buttonFibonacci.Size = new System.Drawing.Size(75, 23);
            this.buttonFibonacci.TabIndex = 3;
            this.buttonFibonacci.Text = "Fibonacci";
            this.buttonFibonacci.UseVisualStyleBackColor = true;
            this.buttonFibonacci.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Advent Sans Logo", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculadora de funciones avanzadas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // entrada
            // 
            this.entrada.Location = new System.Drawing.Point(50, 46);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(187, 20);
            this.entrada.TabIndex = 5;
            this.entrada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // salida
            // 
            this.salida.Location = new System.Drawing.Point(94, 195);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(100, 20);
            this.salida.TabIndex = 6;
            this.salida.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "El copyright  © 2020 by Andres Patiño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingenieria de Sistemas- Programacion Orientada a Objetos II";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button5Factorial
            // 
            this.button5Factorial.Location = new System.Drawing.Point(106, 142);
            this.button5Factorial.Name = "button5Factorial";
            this.button5Factorial.Size = new System.Drawing.Size(75, 23);
            this.button5Factorial.TabIndex = 10;
            this.button5Factorial.Text = "Factorial";
            this.button5Factorial.UseVisualStyleBackColor = true;
            this.button5Factorial.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "borrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 278);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5Factorial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFibonacci);
            this.Controls.Add(this.buttonSerie);
            this.Controls.Add(this.buttonDivisores);
            this.Controls.Add(this.buttonMultiplos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMultiplos;
        private System.Windows.Forms.Button buttonDivisores;
        private System.Windows.Forms.Button buttonSerie;
        private System.Windows.Forms.Button buttonFibonacci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entrada;
        private System.Windows.Forms.TextBox salida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5Factorial;
        private System.Windows.Forms.Button button1;
    }
}

