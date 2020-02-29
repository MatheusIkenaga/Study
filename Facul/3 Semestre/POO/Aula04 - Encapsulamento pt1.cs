using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Início de explicação sobre Encapsulamento
    
   O encapsulamento serve para 'travar' uma variável para que não seja possivel alterar a não ser por 'portas' que eu permita
 * (no caso por métodos)
 *     por exemplo:
   
   Numa conta corrente não seria interessante a possibilidade de ter um 'saldo =10000000' dentro do código
   Pois essa informação não teria segurança*/

namespace Aula04___Encapsulamento
{
    class Conta
    {
        private string nome;
        private double saldo;
        public Conta(string nome)
        {
            this.nome = nome;
            this.saldo = 0;
        }
        public Conta() :
            this("José")
        {
        }
        public void depositar(double valor)
        {
            this.saldo += valor;
        }
        public void sacar(double valor)
        {
            this.saldo -= valor;
        }


        public string getNome() /* get funciona apenas para ler, por isso tem "return" e não void*/
        {
            return this.nome;
        }
        public double getSaldo()
        {
            return this.saldo;
        }

        public void setNome(string novonome)   /* set funciona para escrever na variável private */
        {                                      /* por não retornar nada, possui o void*/
            this.nome = novonome;
        }
        /*public void setSaldo(double novosaldo)            no caso essa parte está como comentário
        {                                                   pois não deve ter forma de alterar o saldo a não ser por
            this.saldo = novosaldo;                         método 'depositar' ou 'sacar'
        }*/
    }

    class Program
    {
        static void Main(string[] args)
        {
            Conta j1 = new Conta("Eduardo");
            j1.setNome("Flávio");
            Console.WriteLine(j1.getNome() + j1.getSaldo());

        }
    }
}
