using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    abstract class Botao
    {
        protected string rotulo;
        private bool status;
        public void setStatus(bool valor) 
        {
            this.status = valor;
        }
        public bool getStatus()
        {
            return this.status;
        }
        abstract public void click ();
        public void MostraBotao() 
        {
            if (this.status)
                Console.WriteLine("Botao {0} Ativo", this.rotulo);
            else
                Console.WriteLine("Botao {0} Inativo", this.rotulo);
        }

    }
    class Ok : Botao
    {
        public Ok()
        {
            base.rotulo = "OK";
            this.setStatus(true);

        }
        public override void click() 
        {
            if (this.getStatus())
                Console.WriteLine("Funcionando");
            /*else
                Console.WriteLine("Deu ruim");*/
        }

    }
    class Cancel : Botao
    {
        public Cancel()
        {
            base.rotulo = "Cancel";
            this.setStatus(false);

        }
        public override void click()
        {
            if (this.getStatus())
                Console.WriteLine("Cancelando");
           /* else
                Console.WriteLine("Deu ruim"); */
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Ok bt1 = new Ok();
            Cancel bt2 = new Cancel();
            bt1.MostraBotao();
            bt2.MostraBotao();
            bt1.click();
            bt2.click(); // Não aparece nada por conta do getStatus do click() dar false, não entra no IF;
            bt1.click();
            bt2.setStatus(true);
            bt2.click();
            bt1.MostraBotao();
            bt2.MostraBotao();
        }
    }
}
