using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncionesCalculadoraAvanzada
{
    public partial class Calculadora : Form
    {
        private int n;
        private int a;
        private String text;

        public Calculadora()
        {
            InitializeComponent();
        }
        private void buttonMult_Click(object sender, EventArgs e)
        {   
            //Hallar multiplos de un numero
            n = int.Parse(entradaDigito.Text);
            for (int i = 0; i <= 9; i++)
            {
                a = n * i;
                text = text + a.ToString() + "  ";
                result.Text = text;
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            //Hallar divisores de un numero
            n = int.Parse(entradaDigito.Text);
            for (int i = 1; i <= n; i++)
            {
                double b = Math.IEEERemainder(n, i);
                if (b == 0)
                {
                    text = text + i.ToString() + "  ";
                    result.Text = text;
                }
            }
        }

        private void buttonSerie_Click(object sender, EventArgs e)
        {
            //Hallar serie y=x^2
            n = int.Parse(entradaDigito.Text);
            for (int i = 1; i <= n; i++)
            {
                double b = Math.Pow(i, 2);
                text = text + b.ToString() + "  ";
                result.Text = text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Hallar factorial
            a = 1;
            n = int.Parse(entradaDigito.Text);
            for (int i = 1; i <= n; i++)
            {
                a = a * i;
            }
            text = text + a.ToString();
            result.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //secuencia fibonacci
            a = 0;
            int b = 1;
            int z = 0;
            n = int.Parse(entradaDigito.Text);
            text = text + b.ToString() + "  ";
            result.Text = text;
            for (int i = 1; i < n; i++)
            {
                z = a;
                a = b;
                b = z + a;
                text = text + b.ToString() + "  ";
                result.Text = text;
            }
        }

        private void buttonEND_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            entradaDigito.Clear();
            result.Clear();
            text = "";
        }

        
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
