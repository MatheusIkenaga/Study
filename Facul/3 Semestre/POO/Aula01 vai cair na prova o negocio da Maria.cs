using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Conta
    {
        public double saldo;
        public double limite;
        public int conta;
    }
    class Gente
    {
        public string nome;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conta cc1,cc2;
            cc1 = new Conta();
            cc1.saldo = 1000;
            cc1.limite = 50;
            cc1.conta = 1;

            cc2 = new Conta();
            cc2.saldo = 1300.45;
            cc2.limite = 55.4;
            cc2.conta = 2;


            Console.WriteLine("Conta: {0}\nSaldo: {1}\nLimite: {2}\n",cc1.conta,cc1.saldo,cc1.limite);

            Console.WriteLine("Conta: {0}\nSaldo: {1}\nLimite: {2}\n", cc2.conta, cc2.saldo, cc2.limite);

            Console.WriteLine("Conta: {0}\n\n\n");

            Gente pessoa1 = new Gente();
            Gente pessoa2 = new Gente();
            pessoa1.nome = "Paulo";
            pessoa1 = pessoa2;
            pessoa2.nome = "Maria";
            Console.WriteLine("{0}", pessoa1.nome);

           /* Sai na tela "Maria", pois pessoa1 é igual ao endereço de memória de pessoa2, 
            * pessoa2 recebe maria depois, porem pessoa1 ainda contem o endereço na sua variável
            Pessoa1 é uma referencia, NÃO O NOME DA VARIÁVEL
            O que fica contido na variável é o PONTEIRO*/

        }
    }
}
