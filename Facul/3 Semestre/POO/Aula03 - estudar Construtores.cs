using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aula_03
{
    class Triangulo
    {
        public float l1, l2, l3;
        public float perimetro;
        public Triangulo() : this(2, 1, 2) 
        {
            this.perimetro=this.calcperimetro();
        }
        public Triangulo(float l1, float l2, float l3) 
        {
            while (!triok(l1, l2, l3))
            {
                Console.WriteLine("Entre com o lado 1");
                l1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Entre com o lado 2");
                l2 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Entre com o lado 3");
                l3 = Convert.ToSingle(Console.ReadLine());
            }
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            this.perimetro=this.calcperimetro();
        }
        public float calcperimetro()
        {
            return this.perimetro = this.l1 + this.l2 + this.l3;
        }
        public bool triok(float l1, float l2, float l3)
        {
            bool ok = true;
            if (l1 >= l2 + l3 || l2 >= l1 + l3 || l3 >= l1 + l2){
                ok = false;
            }else{
                if (l1 == 0 || l2 == 0 || l3 == 0)
                    ok = false;
            }
            return ok;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo(3, 3, 15);
            Console.WriteLine(t1.perimetro);
            /*Triangulo t2 = new Triangulo();
            Console.WriteLine(t2.perimetro);*/

        }
    }
}
