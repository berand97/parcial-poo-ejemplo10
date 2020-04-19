namespace FuncionesCalculadoraAvanzada
{
    partial class Calculadora
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
            this.entradaDigito = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Multiplos = new System.Windows.Forms.Button();
            this.Divisores = new System.Windows.Forms.Button();
            this.Serie = new System.Windows.Forms.Button();
            this.Fibonacci = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Fin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.terminarPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // entradaDigito
            // 
            this.entradaDigito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entradaDigito.Location = new System.Drawing.Point(56, 65);
            this.entradaDigito.Name = "entradaDigito";
            this.entradaDigito.Size = new System.Drawing.Size(217, 22);
            this.entradaDigito.TabIndex = 0;
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(56, 271);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(217, 22);
            this.result.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calculadora de Funciones diversas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funciones";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "SALIDA";
            // 
            // Multiplos
            // 
            this.Multiplos.BackColor = System.Drawing.Color.White;
            this.Multiplos.Location = new System.Drawing.Point(10, 147);
            this.Multiplos.Name = "Multiplos";
            this.Multiplos.Size = new System.Drawing.Size(123, 26);
            this.Multiplos.TabIndex = 5;
            this.Multiplos.Text = "Hallar multiplos";
            this.Multiplos.UseVisualStyleBackColor = false;
            this.Multiplos.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // Divisores
            // 
            this.Divisores.Location = new System.Drawing.Point(10, 210);
            this.Divisores.Name = "Divisores";
            this.Divisores.Size = new System.Drawing.Size(123, 28);
            this.Divisores.TabIndex = 6;
            this.Divisores.Text = "Hallar divisores";
            this.Divisores.UseVisualStyleBackColor = true;
            this.Divisores.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // Serie
            // 
            this.Serie.Location = new System.Drawing.Point(173, 181);
            this.Serie.Name = "Serie";
            this.Serie.Size = new System.Drawing.Size(133, 23);
            this.Serie.TabIndex = 7;
            this.Serie.Text = "Serie y = x²";
            this.Serie.UseVisualStyleBackColor = true;
            this.Serie.Click += new System.EventHandler(this.buttonSerie_Click);
            // 
            // Fibonacci
            // 
            this.Fibonacci.Location = new System.Drawing.Point(173, 147);
            this.Fibonacci.Name = "Fibonacci";
            this.Fibonacci.Size = new System.Drawing.Size(133, 26);
            this.Fibonacci.TabIndex = 9;
            this.Fibonacci.Text = "Secuencia Fibonacci";
            this.Fibonacci.UseVisualStyleBackColor = true;
            this.Fibonacci.Click += new System.EventHandler(this.button2_Click);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(10, 179);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(123, 25);
            this.Factorial.TabIndex = 10;
            this.Factorial.Text = "Hallar Factorial";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.button3_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(56, 299);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(104, 57);
            this.Limpiar.TabIndex = 11;
            this.Limpiar.Text = "BORRAR";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // Fin
            // 
            this.Fin.Location = new System.Drawing.Point(173, 299);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(100, 57);
            this.Fin.TabIndex = 12;
            this.Fin.Text = "SALIR";
            this.Fin.UseVisualStyleBackColor = true;
            this.Fin.Click += new System.EventHandler(this.buttonEND_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminarPrograma});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(323, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // terminarPrograma
            // 
            this.terminarPrograma.Name = "terminarPrograma";
            this.terminarPrograma.Size = new System.Drawing.Size(41, 20);
            this.terminarPrograma.Text = "Salir";
            this.terminarPrograma.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(323, 403);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Fibonacci);
            this.Controls.Add(this.Serie);
            this.Controls.Add(this.Divisores);
            this.Controls.Add(this.Multiplos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.entradaDigito);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "FUNCIONES";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entradaDigito;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Multiplos;
        private System.Windows.Forms.Button Divisores;
        private System.Windows.Forms.Button Serie;
        private System.Windows.Forms.Button Fibonacci;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Fin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem terminarPrograma;
    }
}

