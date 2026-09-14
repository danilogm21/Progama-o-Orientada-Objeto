using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFcomMetodos
{
    internal class ClasseMetodos
    {
        public double SomaNumeros(double x, double y, double z) //Assinatura do método
        {
            double soma;
            soma = x + y + z;
            return soma;
        }
        public double MediaNumeros(double x, double y, double z) //Método para realizar a média
        {
            double media;
            media = SomaNumeros(x, y, z) / 3.0;
            return media;
        }
        public double Maiorumero(double x, double y, double z) //Método para identificar o maior número
        {
            double maior;
            maior = Math.Max(x, Math.Max(y, z));
            return maior;
        }
        public double MenorNumero(double x, double y, double z) //Método para identificar o menor número
        {
            double menor;
            menor = Math.Min(x, Math.Min(y, z));
            return menor;
        }
        public bool VerificaDados(double x, double y, double z) //Método para forçar o usuário digitar apenas números positivos
        {
            if (x < 0 || y < 0 || z < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void MensagemDeErro() //Método para exibir uma mensagem 
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Nenhum Valor digitado pode ser negativo!");
            Console.WriteLine("============================================");
        }
    }
}
