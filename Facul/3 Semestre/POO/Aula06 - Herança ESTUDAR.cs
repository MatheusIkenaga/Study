using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heranca
{
    class Data
    {
        public int getDia()
        {
            return dia;
        }

        public void setDia(int dia)
        {
            this.dia = dia;
        }

        public int getMes()
        {
            return mes;
        }

        public void setMes(int mes)
        {
            this.mes = mes;
        }

        public int getAno()
        {
            return ano;
        }

        public void setAno(int ano)
        {
            this.ano = ano;
        }

        private int dia, mes, ano;

        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public void imprime()
        {
            Console.WriteLine(dia + "/" + mes + "/" + ano);
        }
    }

    class Pessoa
    {
        private String nome;
        private int id;
        private Data nasc;

        /*public Pessoa() 
        {
            this.nome = "";
            this.id = 0;
            this.nasc = new Data(0, 0, 0);
        }*/

        public Pessoa(String nome, int id, Data nasc)
               {
                   this.nome = nome;
                   this.id = id;
                   this.nasc = nasc;
               }
       
        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public Data getNasc()
        {
            return nasc;
        }

        public void setNasc(Data nasc)
        {
            this.nasc = nasc;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public virtual void imprime()
        {
            Console.WriteLine("\nPessoa id= " + id +
                       "    nome= " + nome +
                       "    nascimento= ");
            nasc.imprime();
        }

    }

    class Aluno : Pessoa {

        private String RA;

        // ESTUDAR DAQUI <<<<<<<<<<<<<<<<<<<<<<<
        public Aluno()
            : base("", 0, new Data(0, 0, 0))
        {
        }

        public Aluno(String RA, String nome, int id, Data n) : base(nome, id, n) {
            this.RA = RA;
        }

        public Aluno(Pessoa p, String RA)
            :base(p.getNome(),p.getId(),p.getNasc())
        {
            this.RA = RA;
        }

        public void setRA(String ra) {
            this.RA = ra;
        }
        public override void imprime() {
            base.imprime();
            Console.WriteLine(RA);
        }

        //ATÉ AQUI >>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Jenossidia",66666,new Data (13,08,1982));
            p1.imprime();

            Aluno a1 = new Aluno();
            a1.setNome("Pafuncio");
            a1.setId(12345);
            a1.setNasc(new Data (01,04,1999));
            a1.setRA("ZZ9999");
            a1.imprime();

            Aluno a2 = new Aluno("AAA66777","Apavorada",131317,new Data(11,09,2001));
            a2.imprime();

            Aluno a3 = new Aluno(p1,"666ZZ");
            a3.imprime();
            a3.getNasc().setAno(1990);
            a3.imprime();
        }
    }
}
