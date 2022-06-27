using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1_D.U
{
    public partial class Form1 : Form
    {
        double primero = 0, segundo = 0;
        string operador = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += "9";
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Clear();
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            if (Pantallaprincipal.Text.Trim() == String.Empty)
            {
                return;
            }
            primero = Convert.ToDouble(Pantallaprincipal.Text);
            operador = "*";
            Pantallaprincipal.Clear();
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            if (Pantallaprincipal.Text.Trim() == String.Empty)
            {
                return;
            }
            primero = Convert.ToDouble(Pantallaprincipal.Text);
            operador = "-";
            Pantallaprincipal.Clear();
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            if (Pantallaprincipal.Text.Trim() == String.Empty)
            {
                return;
            }
            primero = Convert.ToDouble(Pantallaprincipal.Text);
            operador = "+";
            Pantallaprincipal.Clear();
        }

        private void Raiz_cuadr_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text = (Math.Sqrt(Convert.ToDouble(Pantallaprincipal.Text))).ToString();
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += "8";
        }

        private void Punto_Click(object sender, EventArgs e)
        {
            Pantallaprincipal.Text += ".";
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            if (Pantallaprincipal.Text.Trim() == String.Empty)
            {
                return;
            }
            segundo = Convert.ToDouble(Pantallaprincipal.Text);
            switch (operador)
            {
                case "+":
                    Pantallaprincipal.Text = (primero + segundo).ToString();
                    break;
                case "-":
                    Pantallaprincipal.Text = (primero - segundo).ToString();
                    break;
                case "*":
                    Pantallaprincipal.Text = (primero * segundo).ToString();
                    break;
                case "/":
                    Pantallaprincipal.Text = (primero / segundo).ToString();
                    break;
            }

        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (Pantallaprincipal.Text.Trim() == String.Empty)
            {
                return;
            }
            primero = Convert.ToDouble(Pantallaprincipal.Text);
            operador = "/";
            Pantallaprincipal.Clear();
        }
        
    }
}
