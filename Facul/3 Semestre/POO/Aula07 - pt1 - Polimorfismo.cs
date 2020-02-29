using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo_e_Classe_Abstrata
{
    class Pessoa
    {
        private string nome;
        public Pessoa(string n)
        {
            this.nome = n;
        }
        public override string ToString()
        {
            return "\n Nome: "+ this.nome;
        }
    }
    class Funcionario : Pessoa
    {
        public float salario;
        public Funcionario(string n, float s)
            : base(n)
        {
            this.salario = s;
        }
        public override string ToString()
        {
            return base.ToString()+ "\n Salario: " + this.salario;
        }
    }
    class Gerente : Funcionario {
        public string depto;
        public Gerente (string d, float s,string n)
            : base(n,s){
                this.depto = d;
            }   
        public override string ToString()
        {
            return base.ToString() + "\n Depto: "+ this.depto;
        }
    }
    class Banco{
        public static float valorEmprestimo (Pessoa p){
            float valor;
            if (p is Gerente)
                valor = ((Gerente)p).salario * 10;
            else if (p is Funcionario)
                valor = ((Funcionario)p).salario * 5;
            else
                valor = 0;
            return valor;

        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa f1 = new Gerente("Vendas", 3000, "Wilrobiçom");
            Console.WriteLine(f1 + "\n Emprestimo:" + Banco.valorEmprestimo(f1));

        }
    }
}
