using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Alongamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //Alongamento
          //Variável - Atribuição - Entrada e Saída
          //Funções para String
            Console.WriteLine("Digite o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a Média");
            double media = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade");
            int idade = int.Parse(Console.ReadLine());
            string mensagem = idade < 18 ? "menor" : "menor";
            Console.WriteLine($"{nome} sua media foi {media}");
            Console.WriteLine($"{nome} você é {mensagem.ToUpper()}");
            Console.ReadKey();
        
        }
    }
}
