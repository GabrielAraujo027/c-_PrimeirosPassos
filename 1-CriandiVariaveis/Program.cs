using System;

namespace variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 1 - Criando Variáveis");
            int idade;
            idade = 27;

            idade = (idade - 2) * 2;

            Console.WriteLine("Minha idade é: " + idade);

            Console.WriteLine("Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
