using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Erros1
{
    class Funcionario
    {
        public int multiplica(int x)
        {
            if (x < 0)
            {
                ArgumentException ae = new ArgumentException();
                throw ae;
            }
            return x * 100;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            int n = 0;
            bool ok = false;
            while (!ok)
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    n = f.multiplica(n);
                    ok = true;
                    
                }
               catch (FormatException)
                {
                    Console.WriteLine("Entre somente com números");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Entre somente com números positivos");
                }
            }

            Console.WriteLine("Resultado " + (n + 10));
        }
    }
}