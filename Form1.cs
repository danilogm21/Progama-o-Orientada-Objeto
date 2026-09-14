using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFcomMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Instanciação da classe de métodos: é o mesmo que criar uma instância, ou criar um ojeto.
        ClasseMetodos calcular = new ClasseMetodos(); //Calcula é um objeto da ClasseMetodos

        private void btnsoma_Click(object sender, EventArgs e)
        {
            //Armazenar os valores fornecidos no TextBoxes em variáveis:
            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);
            double num3 = double.Parse(txtnum3.Text);

            double soma = calcular.SomaNumeros(num1, num2, num3); //Método para somar
            lblresultado.Text = soma.ToString();
        }
        private void btnmedia_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);
            double num3 = double.Parse(txtnum3.Text);

            double media = calcular.MediaNumeros(num1, num2, num3); //Método para fazer a média
            lblresultado.Text = media.ToString();
        }
        private void btnmaior_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);
            double num3 = double.Parse(txtnum3.Text);

            double maior = calcular.Maiorumero(num1, num2, num3); //Método para achar o maior número
            lblresultado.Text = maior.ToString();
        }
        private void btnmenor_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtnum1.Text); 
            double num2 = double.Parse(txtnum2.Text);
            double num3 = double.Parse(txtnum3.Text);

            double menor = calcular.MenorNumero(num1, num2, num3); //Método para achar o menor número
            lblresultado.Text = menor.ToString();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpardados()
        {
            txtnum1.Text = "0";
            txtnum2.Text = "0";
            txtnum3.Text = "0";
            lblresultado.Text = "0";
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limpardados();
        }

    }
}
