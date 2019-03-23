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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSomar_Click(object sender, EventArgs e)
        {
            //Declarando as variaveis num1,num2, resultado e  Soma

            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 + num2;

            //Declarando textbox resultado

            textResultado.Text = resultado.ToString();

            //fim program soma


        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            //Declarando a variaveis num1,num2, Subtrair

            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 - num2;

            //Declarando as variavel textbox resultado

            textResultado.Text = resultado.ToString();

            //fim programa subtrair

        }

        private void BtnMultiplicação_Click(object sender, EventArgs e)
        {
            // Declarando as variaveis, num1, num2, resultado, multiplicação

            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 * num2;

            //Declarando a varievel textbox resultado

            textResultado.Text = resultado.ToString();

            //fim programa multiplicação

        }

        private void BtnDivisão_Click(object sender, EventArgs e)
        {
            //Declarando as variaveis num1, num2, resultado, Divisão

            double num1, num2, resultado;
            num1 = Convert.ToDouble(textNum1.Text);
            num2 = Convert.ToDouble(textNum2.Text);
            resultado = num1 / num2;

            //Declarando a variavel textbox resultado

            textResultado.Text = resultado.ToString();

            // fim programa divisão

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            //Declarando a variavel limpar

            textNum1.Text = " ";
            textNum2.Text = " ";
            textResultado.Text = " ";

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Declarando a variavel Sair

            Close();

        }
    }
}
