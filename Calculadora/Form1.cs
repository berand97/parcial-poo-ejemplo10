using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private int numeroEntrada;
        private int numero;
        private String resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hallar multiplos de un numero
            numeroEntrada = int.Parse(entrada.Text);
            for (int i = 0; i <= 9; i++)
            {
                numero = numeroEntrada * i;
                resultado = resultado + numero.ToString() + "  ";
                salida.Text = resultado;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Hallar divisores de un numero
            numeroEntrada = int.Parse(entrada.Text);
            for (int i = 1; i <= numeroEntrada; i++)
            {
                double b = Math.IEEERemainder(numeroEntrada, i);
                if (b == 0)
                {
                    resultado = resultado + i.ToString() + "  ";
                    salida.Text = resultado;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Hallar serie y=x^2
            numeroEntrada = int.Parse(entrada.Text);
            for (int i = 1; i <= numeroEntrada; i++)
            {
                double b = Math.Pow(i, 2);
                resultado = resultado + b.ToString() + "  ";
                salida.Text = resultado;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //secuencia fibonacci
            numero = 0;
            int b = 1;
            int z = 0;
            numeroEntrada = int.Parse(entrada.Text);
            resultado = resultado + b.ToString() + "  ";
            salida.Text = resultado;
            for (int i = 1; i < numeroEntrada; i++)
            {
                z = numero;
                numero = b;
                b = z + numero;
                resultado = resultado + b.ToString() + "  ";
                salida.Text = resultado;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Hallar factorial
            numero = 1;
            numeroEntrada = int.Parse(entrada.Text);
            for (int i = 1; i <= numeroEntrada; i++)
            {
                numero = numero * i;
            }
            resultado = resultado + numero.ToString();
            salida.Text = resultado;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            entrada.Clear();
            salida.Clear();
            resultado = "";
        }
    }
}
