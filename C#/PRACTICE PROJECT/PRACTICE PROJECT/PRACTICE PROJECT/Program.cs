using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRACTICE_PROJECT
{
    public class Pessoa{
    private String nome;
    private int idade;
    private float altura;
    private float peso;
    public Pessoa()
        {
		Console.WriteLine("Para começar, escreva seu nome");
		setNome( Console.ReadLine());
		Console.WriteLine("\nDigite sua idade");
		setIdade(Convert.ToInt16(Console.ReadLine()));
		Console.WriteLine("\nQual a sua altura?");
		setAltura(Convert.ToSingle(Console.ReadLine()));
		Console.WriteLine("\nQual o seu peso?"); 
        setPeso(Convert.ToSingle(Console.ReadLine()));
	   }
    public void setNome(String nome){
        this.nome = nome;
    }
    public String getNome(){
        return this.nome;
    }
    public void setIdade(int idade){
        this.idade = idade;
    }
    public int getIdade(){
        return this.idade;
    }
    public void setAltura(float altura) {
        this.altura = altura;
    }
    public float getAltura() {
        return this.altura;
    }
    public void setPeso(float peso) {
        this.peso = peso;
    }
    public float getPeso() {
        return this.peso;
    }
}//Terminando classe Pessoa

    public class Exercicio{
	public String nome;
	public int calorias;
	public float time;
	public int repeticao;
	public String observação;
    }
    class Concurso {
        public String concurso;
        public DateTime data_prova;
    }
    public class Treino{
	public Exercicio exercicio;
	public Data dt;
    }
    public class Data{
	public int dia,mes,ano;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo à sua Agenda de treinos =D");
            Console.ReadKey();
            Console.Clear();
            Pessoa p1 = new Pessoa();
            Console.Clear();
            Console.WriteLine("Nome: {0}" ,p1.getNome());
            Console.WriteLine("Idade: {0}", p1.getIdade());
            Console.WriteLine("Altura: {0}", p1.getAltura());
            Console.WriteLine("Peso: {0}", p1.getPeso());
            Console.ReadKey();


        }
    }
}