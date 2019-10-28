using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_4
{
    public partial class Form1 : Form
    {
        bool validar = false;
        double aux = 0;
        bool Adição = false;
        bool Subtração = false;
        bool Multiplicação = false;
        bool Divisão = false;
        bool Potencia = false;
        bool Raiz = false;




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Numerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            textBoxResultado.Text = textBoxResultado.Text + bt.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (validar == true)
            {

            }
            else
            {
                aux = Convert.ToDouble(textBoxResultado.Text);
                textBoxResultado.Text = "";
                validar = true;
            }

            Raiz = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {

            }
            else
            {
                aux = Convert.ToDouble(textBoxResultado.Text);
                textBoxResultado.Text = "";
                validar = true;
            }

            Divisão = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = "";
        }

        private void buttonAdição_Click(object sender, EventArgs e)
        {     
            if (validar == true)
            {
               
            }
            else
            {
                aux = Convert.ToDouble(textBoxResultado.Text);
                textBoxResultado.Text = "";
                validar = true;
            }

            Adição = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            

            if(Adição == true)
            {
                Soma Calc = new Soma();
                textBoxResultado.Text = Convert.ToString(Calc.Calcula(aux, Convert.ToDouble(textBoxResultado.Text)));
                aux = 0;
                validar = false;
                Adição = false;
            }
           else if (Subtração == true)
            {
                Subtração Calc = new Subtração();
                textBoxResultado.Text = Convert.ToString(Calc.Calcula(aux, Convert.ToDouble(textBoxResultado.Text)));
                aux = 0;
                validar = false;
                Subtração = false;

            }
            else if (Multiplicação == true)
            {
                Multiplicação Calc = new Multiplicação();
                textBoxResultado.Text = Convert.ToString(Calc.Calcula(aux, Convert.ToDouble(textBoxResultado.Text)));
                aux = 0;
                validar = false;
                Multiplicação = false;

            }
            else if (Divisão == true)
            {
                Divisão Calc = new Divisão();
                textBoxResultado.Text = Convert.ToString(Calc.Calcula(aux, Convert.ToDouble(textBoxResultado.Text)));
                aux = 0;
                validar = false;
                Divisão = false;

            }
            else if (Potencia == true)
            {
                Potenciação Calc = new Potenciação();
                textBoxResultado.Text = Convert.ToString(Calc.Calcula(aux, Convert.ToDouble(textBoxResultado.Text)));
                aux = 0;
                validar = false;
                Divisão = false;

            }
            else if (Raiz == true)
            {
                Raiz_Quadrada Calc = new Raiz_Quadrada();
                textBoxResultado.Text = Convert.ToString(Calc.Calcula(aux));
                aux = 0;
                validar = false;
                Divisão = false;

            }

        }

      

        private void button13_ClickSubtração(object sender, EventArgs e)
        {
            if (validar == true)
            {

            }
            else
            {
                aux = Convert.ToDouble(textBoxResultado.Text);
                textBoxResultado.Text = "";
                validar = true;
            }

            Subtração = true;
        }

        private void button12Multiplicação_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {

            }
            else
            {
                aux = Convert.ToDouble(textBoxResultado.Text);
                textBoxResultado.Text = "";
                validar = true;
            }

            Multiplicação = true;

        }

        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {

            }
            else
            {
                aux = Convert.ToDouble(textBoxResultado.Text);
                textBoxResultado.Text = "";
                validar = true;
            }

            Potencia = true;
        }
    }
}
