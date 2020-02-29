using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula04___Encapsulamento_pt2_exercicio
{
    class Robo
    {
        private int codIdent;
        private char modelo;
        private int datacriacao;
        public Robo()
        {
            this.codIdent = 12345;
            this.modelo = 'x';
            this.datacriacao = 291220001;
        }

        /*Exercício = Encapsule as variáveis*/

        public void setCodIdent(int newCodIdent)
        { 
            this.codIdent  =newCodIdent ;
        }
        public void setModelo (char newModelo)
        { 
            this.modelo  =newModelo ;
        }
        public void setDatacriacao (int newDatacriacao)
        { 
            this.datacriacao  =newDatacriacao ;
        }

        public int getCodIdent ()
        {
            return this.codIdent;
        }
        public char getModelo ()
        {
            return this.modelo;
        }
        public int getDatacriacao ()
        {
            return this.datacriacao;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Robo r1 = new Robo();
            Robo r2 = new Robo();
            /*r2.codIdent = 444; */
            r2.setCodIdent(444);
            /*r2.modelo = 'z';*/
            r2.setModelo('z');
            Console.WriteLine(/*r1.codIdent); */ r1.getCodIdent());
            Console.WriteLine(/*r1.modelo);   */ r1.getModelo());
            Console.WriteLine(/*r1.datacriacao);*/ r1.getDatacriacao());
            Console.WriteLine(/*r2.codIdent); */ r2.getCodIdent());
            Console.WriteLine(/*r2.modelo);   */ r2.getModelo());
            Console.WriteLine(/*r2.datacriacao);*/ r2.getDatacriacao());
        }
    }
}

/*FEITO -> TREINAR FAZER ALONE*/