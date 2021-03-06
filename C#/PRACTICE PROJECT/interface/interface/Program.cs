﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace @interface
{
    interface iControleRemoto
    {
        void ligar();
        void desligar();
        void aumentarVolume();
        void diminuirVolume();
        void avancar();
        void retroceder();
    }
    class Televisao : iControleRemoto
    {

        private string marca;
        private string modelo;
        private bool ligada;
        private int nivelVolume;
        private int canal;

        public Televisao(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            ligada = false;
            canal = 0;
        }

        public virtual void ligar()
        {
            ligada = true;
        }

        public virtual void desligar()
        {
            ligada = false;
        }

        public virtual void aumentarVolume()
        {
            nivelVolume++;
        }

        public virtual void diminuirVolume()
        {
            nivelVolume--;
        }

        public virtual void avancar()
        {
            canal++;
        }

        public virtual void retroceder()
        {
            canal--;
        }

        public override string ToString()
        {
            string estado = ligada ? "ligada" : "desligada";
            return "Televisao: " + marca + " " + modelo + " " + estado;
        }
    }
    public class DVDPlayer : iControleRemoto
    {

        private string marca;
        private string modelo;
        private bool ligado;
        private bool open;
        private int capitulo;

        public DVDPlayer(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            ligado = false;
            capitulo = 1;
        }

        public virtual void ligar()
        {
            ligado = true;
        }

        public virtual void desligar()
        {
            ligado = false;
        }

        public virtual void aumentarVolume()
        {
            open = true;
        }

        public virtual void diminuirVolume()
        {
            open = false;
        }

        public virtual void avancar()
        {
            capitulo++;
        }

        public virtual void retroceder()
        {
            capitulo--;
        }
        public override string ToString()
        {
            string estado = ligado ? "ligado" : "desligado";
            string combo = open ? "combo aberto" : "combo fechado";
            return "DVDPlayer " + marca + " " + modelo + "\n " + estado + "\bandeja " + combo + "\n capitulo:" + capitulo;
        }
    }
    public class Abajur : iControleRemoto
    {
        public bool luz;
        public Abajur()
        {
            this.luz = false;
        }
        public void ligar()
        {
            this.luz = true;
        }
        public void desligar()
        {
            this.luz = false;
        }
        public void aumentarVolume() { }
        public void diminuirVolume() { }
        public void avancar() { }
        public void retroceder() { }
        public override string ToString()
        {
            return "Abajur:" + (luz?"Aceso":"Apagado");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //	     ControleRemoto philco = new Televisao("Philco", "MultiVision");
            iControleRemoto philco = new Televisao("Philco", "MultiVision");
            iControleRemoto dvdGradiente = new DVDPlayer("Gradiente", "D22");

            philco.ligar();
            dvdGradiente.ligar();

            Console.WriteLine("Aparelhos iniciais:");
            Console.WriteLine(philco);
            Console.WriteLine(dvdGradiente);

            philco.desligar();
            ((DVDPlayer)dvdGradiente).aumentarVolume();

            Console.WriteLine("");
            Console.WriteLine("Aparelhos apos desligar a TV e abrir o combo do DVD:");
            Console.WriteLine(philco);
            Console.WriteLine(dvdGradiente + "\n");
            // Criar um abajur que liga e desliga com este controle remoto

            iControleRemoto Aladin = new Abajur();
            Console.WriteLine(Aladin);
            Aladin.ligar();
            Console.WriteLine(Aladin);

        }
    }
}
