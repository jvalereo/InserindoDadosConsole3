using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Aula38
{
    class Program
    {
        static void Main(string[] args)
        {
            //Treinamento - Aula37, inserir dados, tipo, string, int, float, double, char
            //Jonas Valereo - Técnico em Informática

            //Declarando as variaveis, tipo string , int, float, double, char

            string nome;
            string sobrenome;
            int idade;
            double altura;
            double peso;
            string endereco;
            string cep;
            string cidade;
            string estado;
            string pais;


            //Declarando entrada de dado no console, método ReadLine

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Digite seu idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu altura: ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu endereço: ");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite seu cep: ");
            cep = Console.ReadLine();
            Console.WriteLine("Digite seu cidade: ");
            cidade = Console.ReadLine();
            Console.WriteLine("Digite seu estado: ");
            estado = Console.ReadLine();
            Console.WriteLine("Digite seu pais de origem: ");
            pais = Console.ReadLine();
            Console.WriteLine();


            //Declarando entrada de dado no console, método ReadLine, Concatenação

            Console.WriteLine("O Resultado é: ");
            Console.WriteLine();
            Console.WriteLine("Meu nome: " + nome);
            Console.WriteLine("Meu sobrenome: " + sobrenome);
            Console.WriteLine("Minha idade: " + idade + " anos ");
            Console.WriteLine("Minha altura: " + altura.ToString("F2", CultureInfo.InvariantCulture) + " de altura ");
            Console.WriteLine("Meu peso: " + peso.ToString("F2", CultureInfo.InvariantCulture) + " Kg ");
            Console.WriteLine("Meu endereço: " + endereco);
            Console.WriteLine("Meu cep: " + cep);
            Console.WriteLine("Minha cidade: " + cidade);
            Console.WriteLine("Meu estado: " + estado);
            Console.WriteLine("Meu pais: " + pais);
            

            // saida do aplicativo console, método Readkey, Retorna o valor da tecla pressionada

            Console.ReadKey();
            
            //Fim do programa



            
            
        }
    }
}
