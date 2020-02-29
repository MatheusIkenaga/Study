using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula02
{
    class ContaCorrente
    {
        public int numero;
        public String cliente;
        public float saldo;
        public void depositar(float valor)
        {
            saldo += valor;
        }
        public void sacar(float valor)
        {
            saldo -= valor;
        }

        public void mostra()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Numero {0} ", numero);
            Console.WriteLine("Nome {0} ", cliente);
            Console.WriteLine("Saldo {0} \n\n",saldo);
        }

        public void transferencia(ContaCorrente destino, float quanto)
        {
            sacar(quanto);
            destino.depositar(quanto);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc1 = new ContaCorrente();
            cc1.cliente = "Joaquim";
            cc1.numero = 1;
            cc1.saldo = 0;
            /*cc1.mostra();*/
            cc1.depositar(1000);
            /*cc1.mostra();*/
            ContaCorrente cc2 = new ContaCorrente();
            cc2.cliente = "Damares";
            cc2.numero = 2;
            cc2.saldo = 0;
            /*cc2.mostra();*/

            /* Static é uma variável que está "chumbada na memória", sempre que se referir a ela, será sempre a essa mesma variável"
             * Public é uma variável dentro de um objeto por exemplo, se esse objeto for excluído, a variável também será
             * As variáveis "Public" ficam visiveis a outros objetos */

            cc1.transferencia(cc2, 300);
            cc1.mostra();
            cc2.mostra();



            
        }
    }
}
