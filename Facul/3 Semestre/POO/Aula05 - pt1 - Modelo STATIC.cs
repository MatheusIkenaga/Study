using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula_05___Relacionamentos
{
    public class Data
    {
        private int dia, mes, ano;
        public Data(int d, int m, int a)
        {
            this.dia = d;
            this.mes = m;
            this.ano = a;
        }
        public int getDia()
        {
            return this.dia;
        }
        public void setDia(int d)
        {
            this.dia = d;
        }
        public int getMes()
        {
            return this.mes;
        }
        public void setMes(int m)
        {
            this.mes = m;
        }
        public int getAno()
        {
            return this.ano;
        }
        public void setAno(int a)
        {
            this.ano = a;
        }
        public override string ToString()
        {
            return Convert.ToString(this.dia) + "/" + Convert.ToString(this.mes) + "/" + Convert.ToString(this.ano);
        }
    }
    public class Pessoa
    {
        private string nome;
        private Data nasc;
        public Pessoa(string n, Data d)
        {
            this.nome = n;
            this.nasc = d;
        }
        public Pessoa(string n, int d, int m, int a)
        {
            this.nome = n;
            this.nasc = new Data(d, m, a);
        }
        public Data getNasc()
        {
            return this.nasc;
        }

        public override string ToString()
        {

            return this.nome + "\n" + nasc.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Data d1 = new Data(01, 04, 2000);
            Pessoa p1 = new Pessoa("Florisberto", d1);
            Pessoa p2 = new Pessoa("Jacobina", 25, 11, 1967);
            //p2.nasc.ano = 1970;
            p2.getNasc().setAno(1970);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}